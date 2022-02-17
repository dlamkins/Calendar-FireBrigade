using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarFireBrigade {
    public partial class DiagGeneralSettings : Form {

        private readonly CfbConfig _cfbConfig;
        
        public DiagGeneralSettings() {
            InitializeComponent();
        }

        public DiagGeneralSettings(CfbConfig cfbConfig) : this() {
            _cfbConfig = cfbConfig;

            PopulateUiState();
        }

        private void PopulateUiState() {
            // Detection Types
            tbNonTeamMemberCategories.Text = string.Join("\r\n", _cfbConfig.NonTeamMemberCategories);
            tbOutOfOfficeCategory.Text     = _cfbConfig.OutOfOfficeCategory;
            tbTrainingCategory.Text        = _cfbConfig.TrainingCategory;
            tbAvoidedBlockPatterns.Text    = string.Join("\r\n", _cfbConfig.AvoidedMeetingPatterns);

            // Calendar Syncing
            tbCaseSyncPattern.Text = _cfbConfig.CaseSyncPattern;
            tbSubjectCleanup.Text  = string.Join("\r\n", _cfbConfig.SubjectCleanup);
            nudDaysToSync.Value    = _cfbConfig.DaysToSync;
            nudSyncFrequency.Value = _cfbConfig.SyncFrequency;

            // Team Members
            tbPreferredSpellings.Text = string.Join("\r\n", _cfbConfig.PreferredSpellings);
        }

        private void UpdateState() {
            // Detection Types
            _cfbConfig.NonTeamMemberCategories = tbNonTeamMemberCategories.Text.Split(new []{"\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            _cfbConfig.OutOfOfficeCategory     = tbOutOfOfficeCategory.Text;
            _cfbConfig.TrainingCategory        = tbTrainingCategory.Text;
            _cfbConfig.AvoidedMeetingPatterns  = tbAvoidedBlockPatterns.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Calendar Syncing
            _cfbConfig.CaseSyncPattern = tbCaseSyncPattern.Text;
            _cfbConfig.SubjectCleanup  = tbSubjectCleanup.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            _cfbConfig.DaysToSync      = (int)nudDaysToSync.Value;
            _cfbConfig.SyncFrequency   = (int) nudSyncFrequency.Value;

            // Team Members
            _cfbConfig.PreferredSpellings = tbPreferredSpellings.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void bttnDone_Click(object sender, EventArgs e) {
            UpdateState();
            CfbConfig.SaveState();

            this.Close();
        }

        private void bttnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
