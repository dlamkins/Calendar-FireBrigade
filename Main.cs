using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarFireBrigade.States;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;

namespace CalendarFireBrigade {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            UpdateUiState();
        }

        private void UpdateUiState() {
            lblAbout.Text = string.Format(lblAbout.Text, ProductVersion);

            cbCalendarSyncTargetOptions.Items.Clear();
            cbCalendarSyncTargetOptions.Items.AddRange(Enumerable.Concat(ManagedCalendars.Instance.AvailableTeamCalendars, ManagedCalendars.Instance.EnabledTeamCalendars).Distinct().ToArray());
            cbCalendarSyncTargetOptions.Text = ManagedCalendars.Instance.SelectedSyncCalendar;

            tmrCalendarSync.Stop();
            tmrCalendarSync.Interval = CfbConfig.Instance.SyncFrequency * 1000 * 60;
            tmrCalendarSync.Enabled  = ManagedCalendars.Instance.AutoSync;
        }

        private void bttnManageObservedCalendars_Click(object sender, EventArgs e) {
            var calendarManager = new DiagManageCalendars();

            ManagedCalendars.Instance.AvailableTeamCalendars.ForEach(calendarManager.AvailableCalendars.Add);
            ManagedCalendars.Instance.EnabledTeamCalendars.ForEach(calendarManager.EnabledCalendars.Add);

            if (calendarManager.ShowDialog() == DialogResult.OK) {
                ManagedCalendars.Instance.AvailableTeamCalendars = calendarManager.AvailableCalendars.ToList();
                ManagedCalendars.Instance.EnabledTeamCalendars   = calendarManager.EnabledCalendars.ToList();
                ManagedCalendars.Save();
            }

            UpdateUiState();
        }

        private void bttnSpecificTime60_Click(object sender, EventArgs e) {
            nudSpecificTimeCallDuration.Value = 60;
        }

        private void bttnSpecificTime90_Click(object sender, EventArgs e) {
            nudSpecificTimeCallDuration.Value = 90;
        }

        private void bttnSpecificTime120_Click(object sender, EventArgs e) {
            nudSpecificTimeCallDuration.Value = 120;
        }

        private void bttnAnyAvailability60_Click(object sender, EventArgs e) {
            nudAnyAvailabilityCallDuration.Value = 60;
        }

        private void bttnAnyAvailability90_Click(object sender, EventArgs e) {
            nudAnyAvailabilityCallDuration.Value = 90;
        }

        private void bttnAnyAvailability120_Click(object sender, EventArgs e) {
            nudAnyAvailabilityCallDuration.Value = 120;
        }

        private void bttnShowConsole_Click(object sender, EventArgs e) {
            bttnShowConsole.Hide();

            //DockUtil.LaunchDocked("powershell", splitContainer1.Panel2);
        }

        private void bttnSpecificTimeCalculate_Click(object sender, EventArgs e) {
            bttnReset_Click(null, null);

            var items = new List<TimeSlot>();

            foreach (var calendar in States.ManagedCalendars.Instance.EnabledTeamCalendars) {
                var calendarItems = OutlookInteropUtil.GetCalendarEvents(calendar, dtpSpecificTimeCallStart.Value.Date, dtpSpecificTimeCallStart.Value.Date.AddDays(1));

                items.AddRange(calendarItems);
            }

            foreach (var brigader in items.GroupBy(a => a.Owner).OrderBy(a => a.Count(slot => slot.SlotType != TimeSlotType.Other))) {
                var newView = new BrigadeMemberAvailabilityView() {
                    ConflictingMeetings = brigader.ToArray(),
                    RequestedBlock      = new TimeSlot(brigader.Key, "REQUESTED CALL", dtpSpecificTimeCallStart.Value, (float) nudSpecificTimeCallDuration.Value / 60f),
                    Owner               = brigader.Key,
                    Parent              = flpBrigadePanel
                };
            }
            
        }

        private void bttnReset_Click(object sender, EventArgs e) {
            flpBrigadePanel.Controls.Clear();

            if (sender == null) return;

            nudSpecificTimeCallDuration.Value    = 90;
            nudAnyAvailabilityCallDuration.Value = 90;
        }

        private void cbCalendarSyncTargetOptions_SelectedIndexChanged(object sender, EventArgs e) {
            ManagedCalendars.Instance.SelectedSyncCalendar = cbCalendarSyncTargetOptions.Text;
            ManagedCalendars.Save();
        }

        private void bttnManageTeamMemberCalendars_Click(object sender, EventArgs e) {
            var calendarManager = new DiagManageCalendars();

            ManagedCalendars.Instance.AvailableTeamMemberCalendars.ForEach(calendarManager.AvailableCalendars.Add);
            ManagedCalendars.Instance.EnabledTeamMemberCalendars.ForEach(calendarManager.EnabledCalendars.Add);

            if (calendarManager.ShowDialog() == DialogResult.OK) {
                ManagedCalendars.Instance.AvailableTeamMemberCalendars = calendarManager.AvailableCalendars.ToList();
                ManagedCalendars.Instance.EnabledTeamMemberCalendars   = calendarManager.EnabledCalendars.ToList();
                ManagedCalendars.Save();
            }
        }

        // Gross
        private async Task SyncCalendars() {
            if (!bttnManuallySync.Enabled) return;

            bttnManuallySync.Enabled = false;

            tbSyncFeed.Clear();
            
            tbSyncFeed.AppendText($"Beginning sync ({DateTime.Now:T})...");

            string casePattern = CfbConfig.Instance.CaseSyncPattern;

            var sharedEvents = await Task.Run(() => OutlookInteropUtil.GetCalendarEvents(ManagedCalendars.Instance.SelectedSyncCalendar, DateTime.Today, DateTime.Today.AddDays(7), false));

            var teamCalendars = ManagedCalendars.Instance.EnabledTeamMemberCalendars.ToArray();

            int countSkipped        = 0;
            int countAlreadySynced  = 0;
            int countNotSupportCase = 0;
            int countDidSync        = 0;

            foreach (var teamMemberCalendar in teamCalendars) {
                try {
                    var events = await Task.Run(() => OutlookInteropUtil.GetCalendarEvents(teamMemberCalendar, DateTime.Today, DateTime.Today.AddDays(CfbConfig.Instance.DaysToSync), false));

                    await Task.Delay(1000);

                    foreach (var timeSlot in events) {
                        await Task.Delay(1000);

                        var match = Regex.Match(timeSlot.Subject, casePattern);

                        if (!match.Success) {
                            countSkipped++;
                            continue;
                        }

                        if (sharedEvents.Any(shared => shared.Subject.Contains(match.Groups[1].Value.TrimStart('0')) && shared.StartTime == timeSlot.StartTime)) {
                            countAlreadySynced++;
                            continue;
                        }

                        if (timeSlot.SlotType != TimeSlotType.Case) {
                            countNotSupportCase++;
                            continue;
                        }

                        var targetSync = await Task.Run(() => OutlookInteropUtil.GetCalendar(ManagedCalendars.Instance.SelectedSyncCalendar));
                        await Task.Delay(1000);
                        var folder = await Task.Run(() => targetSync.Mapi.GetSharedDefaultFolder(targetSync.Calendar, OlDefaultFolders.olFolderCalendar));
                        await Task.Delay(1000);

                        var syncEvent = (AppointmentItem)folder.Items.Add(); 
                        syncEvent.Start         = timeSlot.StartTime;
                        syncEvent.End           = timeSlot.EndTime;
                        syncEvent.RTFBody       = timeSlot.OriginalItem.RTFBody;
                        syncEvent.Location      = timeSlot.Owner;
                        syncEvent.Categories    = timeSlot.Owner.Split(' ')[0];

                        string cleanSubject = timeSlot.Subject;

                        foreach (string filteredSubject in CfbConfig.Instance.SubjectCleanup) {
                            cleanSubject = cleanSubject.Replace(filteredSubject, "");
                        }

                        syncEvent.Subject       = cleanSubject;
                        syncEvent.MeetingStatus = OlMeetingStatus.olMeeting;
                        syncEvent.AllDayEvent   = false;
                        syncEvent.BusyStatus    = OlBusyStatus.olBusy;

                        await Task.Run(() => syncEvent.Save());

                        tbSyncFeed.AppendText($"\r\nSynced \"{timeSlot.Subject}\" for {timeSlot.Owner}");

                        countDidSync++;
                    }
                } catch (Exception ex) {
                    tbSyncFeed.AppendText($"        {ex.Message}\r\n");
                }
            }

            tbSyncFeed.AppendText("\r\n\r\nResults:\r\n");
            tbSyncFeed.AppendText($"  Skipped {countSkipped} (No case number)\r\n");
            tbSyncFeed.AppendText($"  Skipped {countAlreadySynced} (Call is already on the calendar)\r\n");
            tbSyncFeed.AppendText($"  Skipped {countNotSupportCase} (Not a case - probably training or something)\r\n\r\n");
            tbSyncFeed.AppendText($"  Found {countDidSync} call(s) needed synced.\r\n");
            tbSyncFeed.AppendText($"\r\n\r\nLast run: {DateTime.Now:T}");

            bttnManuallySync.Enabled = true;
        }

        private async void tmrCalendarSync_Tick(object sender, EventArgs e) {
            await Task.Run(SyncCalendars);
        }

        private async void bttnManuallySync_Click(object sender, EventArgs e) {
            await Task.Run(SyncCalendars);
        }

        private void chAutoSyncTeam_CheckedChanged(object sender, EventArgs e) {
            ManagedCalendars.Instance.AutoSync = cbAutoSyncTeam.Checked;
            ManagedCalendars.Save();

            tmrCalendarSync.Enabled = ManagedCalendars.Instance.AutoSync;
        }

        private void bttnGeneralSettings_Click(object sender, EventArgs e) {
            var generalSettingsDiag = new DiagGeneralSettings(CfbConfig.Instance);

            if (generalSettingsDiag.ShowDialog() == DialogResult.OK) {
                // Apply anything not queried.
                tmrCalendarSync.Stop();
                tmrCalendarSync.Interval = CfbConfig.Instance.SyncFrequency * 1000 * 60;
                tmrCalendarSync.Enabled  = ManagedCalendars.Instance.AutoSync;
            }
        }
    }
}
