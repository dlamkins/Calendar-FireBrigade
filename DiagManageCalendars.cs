using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using CalendarFireBrigade.States;

namespace CalendarFireBrigade {
    public partial class DiagManageCalendars : Form {

        private enum CalendarSetReference {
            None,
            Available,
            Enabled
        }

        public ObservableCollection<string> AvailableCalendars { get; private set; } = new ObservableCollection<string>();
        public ObservableCollection<string> EnabledCalendars   { get; private set; } = new ObservableCollection<string>();

        public DiagManageCalendars() {
            InitializeComponent();

            PopulateFields();

            UpdateViewState(CalendarSetReference.None);

            this.AvailableCalendars.CollectionChanged += OnCalendarCollectionChanged;
            this.EnabledCalendars.CollectionChanged   += OnCalendarCollectionChanged;
        }

        private void OnCalendarCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            PopulateFields();
        }

        private void PopulateFields() {
            lbAvailableCalendars.Items.Clear();
            lbAvailableCalendars.Items.AddRange(this.AvailableCalendars.ToArray());

            lbEnabledCalendars.Items.Clear();
            lbEnabledCalendars.Items.AddRange(this.EnabledCalendars.ToArray());
        }

        private void UpdateViewState(CalendarSetReference calendarSet = CalendarSetReference.None, bool testing = false) {
            // Test, Add
            bttnTestNewCalendar.Enabled = bttnAddNewCalendar.Enabled = tbNewCalendarAddress.Text.Length > 2 && !testing;
            pbTestingProgress.Visible   = testing;

            // ◀, ▶
            bttnEnableCalendar.Enabled  = calendarSet == CalendarSetReference.Available;
            bttnDisableCalendar.Enabled = calendarSet == CalendarSetReference.Enabled;

            // Delete Selected
            bttnDeleteSelectedCalendar.Enabled = calendarSet != CalendarSetReference.None;

            // Available
            if (lbAvailableCalendars.SelectedIndex > -1 && calendarSet != CalendarSetReference.Available) {
                lbAvailableCalendars.SetSelected(lbAvailableCalendars.SelectedIndex, false);
            }

            // Enabled
            if (lbEnabledCalendars.SelectedIndex > -1 && calendarSet != CalendarSetReference.Enabled) {
                lbEnabledCalendars.SetSelected(lbEnabledCalendars.SelectedIndex, false);
            }
        }

        private void tbNewCalendarAddress_TextChanged(object sender, EventArgs e) {
            UpdateViewState(CalendarSetReference.None);
        }

        private void lbAvailableCalendars_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbAvailableCalendars.SelectedItems.Count > 0) {
                UpdateViewState(CalendarSetReference.Available);
            }
        }

        private void lbEnabledCalendars_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbEnabledCalendars.SelectedItems.Count > 0) {
                UpdateViewState(CalendarSetReference.Enabled);
            }
        }

        private void bttnTestNewCalendar_Click(object sender, EventArgs e) {
            UpdateViewState(CalendarSetReference.None, true);
            try {
                var (_, calendar, _) = OutlookInteropUtil.GetCalendar(tbNewCalendarAddress.Text);

                if (calendar.Resolve()) {
                    MessageBox.Show($"{calendar.Name} is valid 👍", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show($"Failed to resolve calendar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) {
                MessageBox.Show($"Failed to resolve calendar: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateViewState(CalendarSetReference.None, false);
        }

        private void bttnAddNewCalendar_Click(object sender, EventArgs e) {
            int newCalendarIndex = lbAvailableCalendars.Items.Add(tbNewCalendarAddress.Text);
            tbNewCalendarAddress.Clear();
            lbAvailableCalendars.SelectedIndex = newCalendarIndex;
        }

        private void bttnDeleteSelectedCalendar_Click(object sender, EventArgs e) {
            if (lbAvailableCalendars.SelectedIndex > -1) {
                lbAvailableCalendars.Items.RemoveAt(lbAvailableCalendars.SelectedIndex);
            }

            if (lbEnabledCalendars.SelectedIndex > -1) {
                lbEnabledCalendars.Items.RemoveAt(lbEnabledCalendars.SelectedIndex);
            }

            UpdateViewState(CalendarSetReference.None);
        }

        private void bttnEnableCalendar_Click(object sender, EventArgs e) {
            if (lbAvailableCalendars.SelectedIndex > -1) {
                int movedCalendar = lbEnabledCalendars.Items.Add(lbAvailableCalendars.Text);
                lbAvailableCalendars.Items.RemoveAt(lbAvailableCalendars.SelectedIndex);
                lbEnabledCalendars.SelectedIndex = movedCalendar;
            }
        }

        private void bttnDisableCalendar_Click(object sender, EventArgs e) {
            if (lbEnabledCalendars.SelectedIndex > -1) {
                int movedCalendar = lbAvailableCalendars.Items.Add(lbEnabledCalendars.Text);
                lbEnabledCalendars.Items.RemoveAt(lbEnabledCalendars.SelectedIndex);
                lbAvailableCalendars.SelectedIndex = movedCalendar;
            }
        }

        private void bttnDone_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DiagManageCalendars_FormClosing(object sender, FormClosingEventArgs e) {
            this.AvailableCalendars.CollectionChanged -= OnCalendarCollectionChanged;
            this.EnabledCalendars.CollectionChanged   -= OnCalendarCollectionChanged;

            this.AvailableCalendars = new ObservableCollection<string>(lbAvailableCalendars.Items.Cast<string>());
            this.EnabledCalendars   = new ObservableCollection<string>(lbEnabledCalendars.Items.Cast<string>());
        }
    }
}
