
namespace CalendarFireBrigade {
    partial class Main {
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbSyncFeed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbShowLogs = new System.Windows.Forms.CheckBox();
            this.cbAutoSyncTeam = new System.Windows.Forms.CheckBox();
            this.bttnManuallySync = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCalendarSyncTargetOptions = new System.Windows.Forms.ComboBox();
            this.bttnManageTeamMemberCalendars = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpBrigadePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnShowConsole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttnManageObservedCalendars = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnSoonestAvailabilityCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnAnyAvailability120 = new System.Windows.Forms.Button();
            this.bttnAnyAvailability90 = new System.Windows.Forms.Button();
            this.bttnAnyAvailabilityCalculate = new System.Windows.Forms.Button();
            this.bttnAnyAvailability60 = new System.Windows.Forms.Button();
            this.dtpAnyAvailabilityCallDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAnyAvailabilityCallDuration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSpecificTime120 = new System.Windows.Forms.Button();
            this.bttnSpecificTime90 = new System.Windows.Forms.Button();
            this.bttnSpecificTime60 = new System.Windows.Forms.Button();
            this.bttnSpecificTimeCalculate = new System.Windows.Forms.Button();
            this.dtpSpecificTimeCallStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSpecificTimeCallDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.bttnGeneralSettings = new System.Windows.Forms.Button();
            this.tmrCalendarSync = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnyAvailabilityCallDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecificTimeCallDuration)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tbSyncFeed);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Team Calendar Sync";
            // 
            // tbSyncFeed
            // 
            this.tbSyncFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSyncFeed.Location = new System.Drawing.Point(3, 103);
            this.tbSyncFeed.Multiline = true;
            this.tbSyncFeed.Name = "tbSyncFeed";
            this.tbSyncFeed.ReadOnly = true;
            this.tbSyncFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSyncFeed.Size = new System.Drawing.Size(791, 463);
            this.tbSyncFeed.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbShowLogs);
            this.panel2.Controls.Add(this.cbAutoSyncTeam);
            this.panel2.Controls.Add(this.bttnManuallySync);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbCalendarSyncTargetOptions);
            this.panel2.Controls.Add(this.bttnManageTeamMemberCalendars);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 100);
            this.panel2.TabIndex = 0;
            // 
            // cbShowLogs
            // 
            this.cbShowLogs.AutoSize = true;
            this.cbShowLogs.Location = new System.Drawing.Point(489, 62);
            this.cbShowLogs.Name = "cbShowLogs";
            this.cbShowLogs.Size = new System.Drawing.Size(131, 17);
            this.cbShowLogs.TabIndex = 13;
            this.cbShowLogs.Text = "Show All Log Entries";
            this.cbShowLogs.UseVisualStyleBackColor = true;
            this.cbShowLogs.Visible = false;
            // 
            // cbAutoSyncTeam
            // 
            this.cbAutoSyncTeam.AutoSize = true;
            this.cbAutoSyncTeam.Location = new System.Drawing.Point(408, 62);
            this.cbAutoSyncTeam.Name = "cbAutoSyncTeam";
            this.cbAutoSyncTeam.Size = new System.Drawing.Size(77, 17);
            this.cbAutoSyncTeam.TabIndex = 12;
            this.cbAutoSyncTeam.Text = "Auto Sync";
            this.cbAutoSyncTeam.UseVisualStyleBackColor = true;
            this.cbAutoSyncTeam.CheckedChanged += new System.EventHandler(this.chAutoSyncTeam_CheckedChanged);
            // 
            // bttnManuallySync
            // 
            this.bttnManuallySync.Location = new System.Drawing.Point(306, 59);
            this.bttnManuallySync.Name = "bttnManuallySync";
            this.bttnManuallySync.Size = new System.Drawing.Size(96, 23);
            this.bttnManuallySync.TabIndex = 11;
            this.bttnManuallySync.Text = "Manually Sync";
            this.bttnManuallySync.UseVisualStyleBackColor = true;
            this.bttnManuallySync.Click += new System.EventHandler(this.bttnManuallySync_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Target Calendar";
            // 
            // cbCalendarSyncTargetOptions
            // 
            this.cbCalendarSyncTargetOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalendarSyncTargetOptions.FormattingEnabled = true;
            this.cbCalendarSyncTargetOptions.Location = new System.Drawing.Point(16, 61);
            this.cbCalendarSyncTargetOptions.Name = "cbCalendarSyncTargetOptions";
            this.cbCalendarSyncTargetOptions.Size = new System.Drawing.Size(284, 21);
            this.cbCalendarSyncTargetOptions.TabIndex = 2;
            this.cbCalendarSyncTargetOptions.SelectedIndexChanged += new System.EventHandler(this.cbCalendarSyncTargetOptions_SelectedIndexChanged);
            // 
            // bttnManageTeamMemberCalendars
            // 
            this.bttnManageTeamMemberCalendars.Location = new System.Drawing.Point(16, 13);
            this.bttnManageTeamMemberCalendars.Name = "bttnManageTeamMemberCalendars";
            this.bttnManageTeamMemberCalendars.Size = new System.Drawing.Size(284, 23);
            this.bttnManageTeamMemberCalendars.TabIndex = 10;
            this.bttnManageTeamMemberCalendars.Text = "Manage Team Member Calendars";
            this.bttnManageTeamMemberCalendars.UseVisualStyleBackColor = true;
            this.bttnManageTeamMemberCalendars.Click += new System.EventHandler(this.bttnManageTeamMemberCalendars_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team Availability Query";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 165);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.flpBrigadePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bttnShowConsole);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(791, 401);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 6;
            // 
            // flpBrigadePanel
            // 
            this.flpBrigadePanel.AutoScroll = true;
            this.flpBrigadePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBrigadePanel.Location = new System.Drawing.Point(0, 0);
            this.flpBrigadePanel.Name = "flpBrigadePanel";
            this.flpBrigadePanel.Size = new System.Drawing.Size(791, 401);
            this.flpBrigadePanel.TabIndex = 0;
            // 
            // bttnShowConsole
            // 
            this.bttnShowConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnShowConsole.Location = new System.Drawing.Point(335, 44);
            this.bttnShowConsole.Name = "bttnShowConsole";
            this.bttnShowConsole.Size = new System.Drawing.Size(121, 23);
            this.bttnShowConsole.TabIndex = 0;
            this.bttnShowConsole.Text = "Show Console";
            this.bttnShowConsole.UseVisualStyleBackColor = true;
            this.bttnShowConsole.Click += new System.EventHandler(this.bttnShowConsole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 162);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttnManageObservedCalendars);
            this.groupBox3.Controls.Add(this.bttnReset);
            this.groupBox3.Controls.Add(this.bttnSoonestAvailabilityCalculate);
            this.groupBox3.Location = new System.Drawing.Point(529, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 153);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // bttnManageObservedCalendars
            // 
            this.bttnManageObservedCalendars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnManageObservedCalendars.Location = new System.Drawing.Point(34, 38);
            this.bttnManageObservedCalendars.Name = "bttnManageObservedCalendars";
            this.bttnManageObservedCalendars.Size = new System.Drawing.Size(188, 23);
            this.bttnManageObservedCalendars.TabIndex = 9;
            this.bttnManageObservedCalendars.Text = "Manage Team Calendars";
            this.bttnManageObservedCalendars.UseVisualStyleBackColor = true;
            this.bttnManageObservedCalendars.Click += new System.EventHandler(this.bttnManageObservedCalendars_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReset.Location = new System.Drawing.Point(34, 119);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(188, 23);
            this.bttnReset.TabIndex = 8;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnSoonestAvailabilityCalculate
            // 
            this.bttnSoonestAvailabilityCalculate.Enabled = false;
            this.bttnSoonestAvailabilityCalculate.Location = new System.Drawing.Point(34, 64);
            this.bttnSoonestAvailabilityCalculate.Name = "bttnSoonestAvailabilityCalculate";
            this.bttnSoonestAvailabilityCalculate.Size = new System.Drawing.Size(188, 23);
            this.bttnSoonestAvailabilityCalculate.TabIndex = 7;
            this.bttnSoonestAvailabilityCalculate.Text = "Soonest Availability";
            this.bttnSoonestAvailabilityCalculate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttnAnyAvailability120);
            this.groupBox2.Controls.Add(this.bttnAnyAvailability90);
            this.groupBox2.Controls.Add(this.bttnAnyAvailabilityCalculate);
            this.groupBox2.Controls.Add(this.bttnAnyAvailability60);
            this.groupBox2.Controls.Add(this.dtpAnyAvailabilityCallDay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudAnyAvailabilityCallDuration);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(267, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Any Availability";
            // 
            // bttnAnyAvailability120
            // 
            this.bttnAnyAvailability120.Location = new System.Drawing.Point(183, 89);
            this.bttnAnyAvailability120.Name = "bttnAnyAvailability120";
            this.bttnAnyAvailability120.Size = new System.Drawing.Size(39, 23);
            this.bttnAnyAvailability120.TabIndex = 11;
            this.bttnAnyAvailability120.Text = "120";
            this.bttnAnyAvailability120.UseVisualStyleBackColor = true;
            this.bttnAnyAvailability120.Click += new System.EventHandler(this.bttnAnyAvailability120_Click);
            // 
            // bttnAnyAvailability90
            // 
            this.bttnAnyAvailability90.Location = new System.Drawing.Point(150, 89);
            this.bttnAnyAvailability90.Name = "bttnAnyAvailability90";
            this.bttnAnyAvailability90.Size = new System.Drawing.Size(27, 23);
            this.bttnAnyAvailability90.TabIndex = 10;
            this.bttnAnyAvailability90.Text = "90";
            this.bttnAnyAvailability90.UseVisualStyleBackColor = true;
            this.bttnAnyAvailability90.Click += new System.EventHandler(this.bttnAnyAvailability90_Click);
            // 
            // bttnAnyAvailabilityCalculate
            // 
            this.bttnAnyAvailabilityCalculate.Location = new System.Drawing.Point(34, 119);
            this.bttnAnyAvailabilityCalculate.Name = "bttnAnyAvailabilityCalculate";
            this.bttnAnyAvailabilityCalculate.Size = new System.Drawing.Size(188, 23);
            this.bttnAnyAvailabilityCalculate.TabIndex = 5;
            this.bttnAnyAvailabilityCalculate.Text = "Calculate";
            this.bttnAnyAvailabilityCalculate.UseVisualStyleBackColor = true;
            // 
            // bttnAnyAvailability60
            // 
            this.bttnAnyAvailability60.Location = new System.Drawing.Point(117, 89);
            this.bttnAnyAvailability60.Name = "bttnAnyAvailability60";
            this.bttnAnyAvailability60.Size = new System.Drawing.Size(27, 23);
            this.bttnAnyAvailability60.TabIndex = 9;
            this.bttnAnyAvailability60.Text = "60";
            this.bttnAnyAvailability60.UseVisualStyleBackColor = true;
            this.bttnAnyAvailability60.Click += new System.EventHandler(this.bttnAnyAvailability60_Click);
            // 
            // dtpAnyAvailabilityCallDay
            // 
            this.dtpAnyAvailabilityCallDay.CustomFormat = "dddd MM/dd";
            this.dtpAnyAvailabilityCallDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnyAvailabilityCallDay.Location = new System.Drawing.Point(34, 41);
            this.dtpAnyAvailabilityCallDay.Name = "dtpAnyAvailabilityCallDay";
            this.dtpAnyAvailabilityCallDay.Size = new System.Drawing.Size(188, 22);
            this.dtpAnyAvailabilityCallDay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Call Day";
            // 
            // nudAnyAvailabilityCallDuration
            // 
            this.nudAnyAvailabilityCallDuration.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAnyAvailabilityCallDuration.Location = new System.Drawing.Point(34, 90);
            this.nudAnyAvailabilityCallDuration.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudAnyAvailabilityCallDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAnyAvailabilityCallDuration.Name = "nudAnyAvailabilityCallDuration";
            this.nudAnyAvailabilityCallDuration.Size = new System.Drawing.Size(77, 22);
            this.nudAnyAvailabilityCallDuration.TabIndex = 3;
            this.nudAnyAvailabilityCallDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anticipated Call Duration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnSpecificTime120);
            this.groupBox1.Controls.Add(this.bttnSpecificTime90);
            this.groupBox1.Controls.Add(this.bttnSpecificTime60);
            this.groupBox1.Controls.Add(this.bttnSpecificTimeCalculate);
            this.groupBox1.Controls.Add(this.dtpSpecificTimeCallStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSpecificTimeCallDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specific Time";
            // 
            // bttnSpecificTime120
            // 
            this.bttnSpecificTime120.Location = new System.Drawing.Point(183, 89);
            this.bttnSpecificTime120.Name = "bttnSpecificTime120";
            this.bttnSpecificTime120.Size = new System.Drawing.Size(39, 23);
            this.bttnSpecificTime120.TabIndex = 8;
            this.bttnSpecificTime120.Text = "120";
            this.bttnSpecificTime120.UseVisualStyleBackColor = true;
            this.bttnSpecificTime120.Click += new System.EventHandler(this.bttnSpecificTime120_Click);
            // 
            // bttnSpecificTime90
            // 
            this.bttnSpecificTime90.Location = new System.Drawing.Point(150, 89);
            this.bttnSpecificTime90.Name = "bttnSpecificTime90";
            this.bttnSpecificTime90.Size = new System.Drawing.Size(27, 23);
            this.bttnSpecificTime90.TabIndex = 7;
            this.bttnSpecificTime90.Text = "90";
            this.bttnSpecificTime90.UseVisualStyleBackColor = true;
            this.bttnSpecificTime90.Click += new System.EventHandler(this.bttnSpecificTime90_Click);
            // 
            // bttnSpecificTime60
            // 
            this.bttnSpecificTime60.Location = new System.Drawing.Point(117, 89);
            this.bttnSpecificTime60.Name = "bttnSpecificTime60";
            this.bttnSpecificTime60.Size = new System.Drawing.Size(27, 23);
            this.bttnSpecificTime60.TabIndex = 6;
            this.bttnSpecificTime60.Text = "60";
            this.bttnSpecificTime60.UseVisualStyleBackColor = true;
            this.bttnSpecificTime60.Click += new System.EventHandler(this.bttnSpecificTime60_Click);
            // 
            // bttnSpecificTimeCalculate
            // 
            this.bttnSpecificTimeCalculate.Location = new System.Drawing.Point(34, 119);
            this.bttnSpecificTimeCalculate.Name = "bttnSpecificTimeCalculate";
            this.bttnSpecificTimeCalculate.Size = new System.Drawing.Size(188, 23);
            this.bttnSpecificTimeCalculate.TabIndex = 5;
            this.bttnSpecificTimeCalculate.Text = "Calculate";
            this.bttnSpecificTimeCalculate.UseVisualStyleBackColor = true;
            this.bttnSpecificTimeCalculate.Click += new System.EventHandler(this.bttnSpecificTimeCalculate_Click);
            // 
            // dtpSpecificTimeCallStart
            // 
            this.dtpSpecificTimeCallStart.CustomFormat = "dddd MM/dd hh:mm tt";
            this.dtpSpecificTimeCallStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSpecificTimeCallStart.Location = new System.Drawing.Point(34, 41);
            this.dtpSpecificTimeCallStart.Name = "dtpSpecificTimeCallStart";
            this.dtpSpecificTimeCallStart.Size = new System.Drawing.Size(188, 22);
            this.dtpSpecificTimeCallStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Call Start";
            // 
            // nudSpecificTimeCallDuration
            // 
            this.nudSpecificTimeCallDuration.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSpecificTimeCallDuration.Location = new System.Drawing.Point(34, 90);
            this.nudSpecificTimeCallDuration.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudSpecificTimeCallDuration.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpecificTimeCallDuration.Name = "nudSpecificTimeCallDuration";
            this.nudSpecificTimeCallDuration.Size = new System.Drawing.Size(77, 22);
            this.nudSpecificTimeCallDuration.TabIndex = 3;
            this.nudSpecificTimeCallDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anticipated Call Duration";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.bttnGeneralSettings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 569);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Other";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAbout);
            this.groupBox4.Location = new System.Drawing.Point(8, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox4.Size = new System.Drawing.Size(246, 85);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "About";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(15, 27);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(184, 39);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Calendar FireBrigade v{0}\r\n\r\nDade Lamkins (dade@lamkins.org)";
            // 
            // bttnGeneralSettings
            // 
            this.bttnGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnGeneralSettings.Location = new System.Drawing.Point(8, 6);
            this.bttnGeneralSettings.Name = "bttnGeneralSettings";
            this.bttnGeneralSettings.Size = new System.Drawing.Size(781, 23);
            this.bttnGeneralSettings.TabIndex = 0;
            this.bttnGeneralSettings.Text = "General Settings";
            this.bttnGeneralSettings.UseVisualStyleBackColor = true;
            this.bttnGeneralSettings.Click += new System.EventHandler(this.bttnGeneralSettings_Click);
            // 
            // tmrCalendarSync
            // 
            this.tmrCalendarSync.Interval = 300000;
            this.tmrCalendarSync.Tick += new System.EventHandler(this.tmrCalendarSync_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 595);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Calendar FireBrigade";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnyAvailabilityCallDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpecificTimeCallDuration)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtpSpecificTimeCallStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSpecificTimeCallDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnSpecificTimeCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttnAnyAvailabilityCalculate;
        private System.Windows.Forms.DateTimePicker dtpAnyAvailabilityCallDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAnyAvailabilityCallDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnSoonestAvailabilityCalculate;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnSpecificTime120;
        private System.Windows.Forms.Button bttnSpecificTime90;
        private System.Windows.Forms.Button bttnSpecificTime60;
        private System.Windows.Forms.Button bttnAnyAvailability120;
        private System.Windows.Forms.Button bttnAnyAvailability90;
        private System.Windows.Forms.Button bttnAnyAvailability60;
        private System.Windows.Forms.FlowLayoutPanel flpBrigadePanel;
        private System.Windows.Forms.Button bttnShowConsole;
        private System.Windows.Forms.Button bttnManageObservedCalendars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSyncFeed;
        private System.Windows.Forms.Button bttnManageTeamMemberCalendars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCalendarSyncTargetOptions;
        private System.Windows.Forms.Timer tmrCalendarSync;
        private System.Windows.Forms.Button bttnManuallySync;
        private System.Windows.Forms.CheckBox cbAutoSyncTeam;
        private System.Windows.Forms.CheckBox cbShowLogs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bttnGeneralSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAbout;
    }
}

