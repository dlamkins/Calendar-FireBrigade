
namespace CalendarFireBrigade {
    partial class DiagGeneralSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagGeneralSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnDone = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAvoidedBlockPatterns = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOutOfOfficeCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNonTeamMemberCategories = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSyncFrequency = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDaysToSync = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubjectCleanup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCaseSyncPattern = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPreferredSpellings = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTrainingCategory = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSyncFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToSync)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnCancel);
            this.panel1.Controls.Add(this.bttnDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 47);
            this.panel1.TabIndex = 2;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(482, 12);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 1;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnDone
            // 
            this.bttnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnDone.Location = new System.Drawing.Point(563, 12);
            this.bttnDone.Name = "bttnDone";
            this.bttnDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttnDone.Size = new System.Drawing.Size(75, 23);
            this.bttnDone.TabIndex = 0;
            this.bttnDone.Text = "Save";
            this.bttnDone.UseVisualStyleBackColor = true;
            this.bttnDone.Click += new System.EventHandler(this.bttnDone_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 374);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbTrainingCategory);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbAvoidedBlockPatterns);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbOutOfOfficeCategory);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbNonTeamMemberCategories);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage2.Size = new System.Drawing.Size(642, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detection Types";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(371, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 80);
            this.label13.TabIndex = 14;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 229);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Avoided Block Patterns";
            // 
            // tbAvoidedBlockPatterns
            // 
            this.tbAvoidedBlockPatterns.Location = new System.Drawing.Point(15, 245);
            this.tbAvoidedBlockPatterns.Multiline = true;
            this.tbAvoidedBlockPatterns.Name = "tbAvoidedBlockPatterns";
            this.tbAvoidedBlockPatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAvoidedBlockPatterns.Size = new System.Drawing.Size(350, 80);
            this.tbAvoidedBlockPatterns.TabIndex = 12;
            this.tbAvoidedBlockPatterns.Text = ".*1-on-1.*\r\n.*tentative.*";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 80);
            this.label11.TabIndex = 10;
            this.label11.Text = "Categories which are not meant to represent a team member.  Not case sensitive.";
            // 
            // tbOutOfOfficeCategory
            // 
            this.tbOutOfOfficeCategory.Location = new System.Drawing.Point(15, 139);
            this.tbOutOfOfficeCategory.Name = "tbOutOfOfficeCategory";
            this.tbOutOfOfficeCategory.Size = new System.Drawing.Size(350, 22);
            this.tbOutOfOfficeCategory.TabIndex = 9;
            this.tbOutOfOfficeCategory.Text = "OOO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Out of Office Category";
            // 
            // tbNonTeamMemberCategories
            // 
            this.tbNonTeamMemberCategories.Location = new System.Drawing.Point(15, 28);
            this.tbNonTeamMemberCategories.Multiline = true;
            this.tbNonTeamMemberCategories.Name = "tbNonTeamMemberCategories";
            this.tbNonTeamMemberCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNonTeamMemberCategories.Size = new System.Drawing.Size(350, 80);
            this.tbNonTeamMemberCategories.TabIndex = 5;
            this.tbNonTeamMemberCategories.Text = "Announcements\r\nMonitor EMEA\r\nTraining\r\nTime Slot\r\nT2 Onboarding\r\nOOO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Non-Team Member Categories";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nudSyncFrequency);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nudDaysToSync);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbSubjectCleanup);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbCaseSyncPattern);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage1.Size = new System.Drawing.Size(642, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calendar Syncing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Time between each sync in minutes.";
            // 
            // nudSyncFrequency
            // 
            this.nudSyncFrequency.Location = new System.Drawing.Point(15, 246);
            this.nudSyncFrequency.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSyncFrequency.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSyncFrequency.Name = "nudSyncFrequency";
            this.nudSyncFrequency.Size = new System.Drawing.Size(350, 22);
            this.nudSyncFrequency.TabIndex = 11;
            this.nudSyncFrequency.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sync Frequency";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number of days beyond today to sync calendars.  More days can take longer to sync" +
    ".";
            // 
            // nudDaysToSync
            // 
            this.nudDaysToSync.Location = new System.Drawing.Point(15, 193);
            this.nudDaysToSync.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDaysToSync.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDaysToSync.Name = "nudDaysToSync";
            this.nudDaysToSync.Size = new System.Drawing.Size(350, 22);
            this.nudDaysToSync.TabIndex = 8;
            this.nudDaysToSync.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Days to Sync";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "A list of things to remove from subject lines when they are synced.  Case sensiti" +
    "ve.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Cleanup";
            // 
            // tbSubjectCleanup
            // 
            this.tbSubjectCleanup.Location = new System.Drawing.Point(15, 82);
            this.tbSubjectCleanup.Multiline = true;
            this.tbSubjectCleanup.Name = "tbSubjectCleanup";
            this.tbSubjectCleanup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSubjectCleanup.Size = new System.Drawing.Size(350, 80);
            this.tbSubjectCleanup.TabIndex = 4;
            this.tbSubjectCleanup.Text = "Remote Session for Case No.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 43);
            this.label5.TabIndex = 3;
            this.label5.Text = "The RegEx pattern used to decide which events should be synced as case calls.  No" +
    "t case sensitive.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Case Sync Pattern";
            // 
            // tbCaseSyncPattern
            // 
            this.tbCaseSyncPattern.Location = new System.Drawing.Point(15, 28);
            this.tbCaseSyncPattern.Name = "tbCaseSyncPattern";
            this.tbCaseSyncPattern.Size = new System.Drawing.Size(350, 22);
            this.tbCaseSyncPattern.TabIndex = 1;
            this.tbCaseSyncPattern.Text = ".*(0?[4-9]\\d{5}).";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.tbPreferredSpellings);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(12);
            this.tabPage3.Size = new System.Drawing.Size(642, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Team Members";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(374, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(256, 244);
            this.label15.TabIndex = 6;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // tbPreferredSpellings
            // 
            this.tbPreferredSpellings.BackColor = System.Drawing.Color.White;
            this.tbPreferredSpellings.Location = new System.Drawing.Point(18, 28);
            this.tbPreferredSpellings.Multiline = true;
            this.tbPreferredSpellings.Name = "tbPreferredSpellings";
            this.tbPreferredSpellings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPreferredSpellings.Size = new System.Drawing.Size(350, 244);
            this.tbPreferredSpellings.TabIndex = 5;
            this.tbPreferredSpellings.Text = "James Brooks=Jimi Brooks\r\nJeffrey Lebda=Jeffle Lebda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Preferred Spellings";
            // 
            // tbTrainingCategory
            // 
            this.tbTrainingCategory.Location = new System.Drawing.Point(15, 192);
            this.tbTrainingCategory.Name = "tbTrainingCategory";
            this.tbTrainingCategory.Size = new System.Drawing.Size(350, 22);
            this.tbTrainingCategory.TabIndex = 16;
            this.tbTrainingCategory.Text = "Training";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Training Category";
            // 
            // DiagGeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiagGeneralSettings";
            this.Text = "General Settings";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSyncFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToSync)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnDone;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCaseSyncPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubjectCleanup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudDaysToSync;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSyncFrequency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNonTeamMemberCategories;
        private System.Windows.Forms.TextBox tbOutOfOfficeCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAvoidedBlockPatterns;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPreferredSpellings;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTrainingCategory;
        private System.Windows.Forms.Label label16;
    }
}