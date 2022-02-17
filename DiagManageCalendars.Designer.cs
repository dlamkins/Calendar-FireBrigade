
namespace CalendarFireBrigade {
    partial class DiagManageCalendars {
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
            this.bttnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAvailableCalendars = new System.Windows.Forms.ListBox();
            this.bttnEnableCalendar = new System.Windows.Forms.Button();
            this.bttnDisableCalendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEnabledCalendars = new System.Windows.Forms.ListBox();
            this.bttnDeleteSelectedCalendar = new System.Windows.Forms.Button();
            this.tbNewCalendarAddress = new System.Windows.Forms.TextBox();
            this.bttnAddNewCalendar = new System.Windows.Forms.Button();
            this.bttnTestNewCalendar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbTestingProgress = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnDone
            // 
            this.bttnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDone.Location = new System.Drawing.Point(318, 12);
            this.bttnDone.Name = "bttnDone";
            this.bttnDone.Size = new System.Drawing.Size(75, 23);
            this.bttnDone.TabIndex = 0;
            this.bttnDone.Text = "Done";
            this.bttnDone.UseVisualStyleBackColor = true;
            this.bttnDone.Click += new System.EventHandler(this.bttnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bttnDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 47);
            this.panel1.TabIndex = 1;
            // 
            // lbAvailableCalendars
            // 
            this.lbAvailableCalendars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAvailableCalendars.FormattingEnabled = true;
            this.lbAvailableCalendars.Location = new System.Drawing.Point(12, 119);
            this.lbAvailableCalendars.Name = "lbAvailableCalendars";
            this.lbAvailableCalendars.Size = new System.Drawing.Size(173, 160);
            this.lbAvailableCalendars.TabIndex = 2;
            this.lbAvailableCalendars.SelectedIndexChanged += new System.EventHandler(this.lbAvailableCalendars_SelectedIndexChanged);
            // 
            // bttnEnableCalendar
            // 
            this.bttnEnableCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnEnableCalendar.Location = new System.Drawing.Point(191, 157);
            this.bttnEnableCalendar.Name = "bttnEnableCalendar";
            this.bttnEnableCalendar.Size = new System.Drawing.Size(23, 23);
            this.bttnEnableCalendar.TabIndex = 3;
            this.bttnEnableCalendar.Text = "▶";
            this.bttnEnableCalendar.UseVisualStyleBackColor = true;
            this.bttnEnableCalendar.Click += new System.EventHandler(this.bttnEnableCalendar_Click);
            // 
            // bttnDisableCalendar
            // 
            this.bttnDisableCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDisableCalendar.Location = new System.Drawing.Point(191, 186);
            this.bttnDisableCalendar.Name = "bttnDisableCalendar";
            this.bttnDisableCalendar.Size = new System.Drawing.Size(23, 23);
            this.bttnDisableCalendar.TabIndex = 5;
            this.bttnDisableCalendar.Text = "◀";
            this.bttnDisableCalendar.UseVisualStyleBackColor = true;
            this.bttnDisableCalendar.Click += new System.EventHandler(this.bttnDisableCalendar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enabled";
            // 
            // lbEnabledCalendars
            // 
            this.lbEnabledCalendars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEnabledCalendars.FormattingEnabled = true;
            this.lbEnabledCalendars.Location = new System.Drawing.Point(220, 119);
            this.lbEnabledCalendars.Name = "lbEnabledCalendars";
            this.lbEnabledCalendars.Size = new System.Drawing.Size(173, 160);
            this.lbEnabledCalendars.TabIndex = 8;
            this.lbEnabledCalendars.SelectedIndexChanged += new System.EventHandler(this.lbEnabledCalendars_SelectedIndexChanged);
            // 
            // bttnDeleteSelectedCalendar
            // 
            this.bttnDeleteSelectedCalendar.Location = new System.Drawing.Point(191, 215);
            this.bttnDeleteSelectedCalendar.Name = "bttnDeleteSelectedCalendar";
            this.bttnDeleteSelectedCalendar.Size = new System.Drawing.Size(23, 23);
            this.bttnDeleteSelectedCalendar.TabIndex = 9;
            this.bttnDeleteSelectedCalendar.Text = "❌";
            this.bttnDeleteSelectedCalendar.UseVisualStyleBackColor = true;
            this.bttnDeleteSelectedCalendar.Click += new System.EventHandler(this.bttnDeleteSelectedCalendar_Click);
            // 
            // tbNewCalendarAddress
            // 
            this.tbNewCalendarAddress.Location = new System.Drawing.Point(12, 25);
            this.tbNewCalendarAddress.Name = "tbNewCalendarAddress";
            this.tbNewCalendarAddress.Size = new System.Drawing.Size(381, 22);
            this.tbNewCalendarAddress.TabIndex = 10;
            this.tbNewCalendarAddress.TextChanged += new System.EventHandler(this.tbNewCalendarAddress_TextChanged);
            // 
            // bttnAddNewCalendar
            // 
            this.bttnAddNewCalendar.Location = new System.Drawing.Point(318, 51);
            this.bttnAddNewCalendar.Name = "bttnAddNewCalendar";
            this.bttnAddNewCalendar.Size = new System.Drawing.Size(75, 23);
            this.bttnAddNewCalendar.TabIndex = 11;
            this.bttnAddNewCalendar.Text = "Add";
            this.bttnAddNewCalendar.UseVisualStyleBackColor = true;
            this.bttnAddNewCalendar.Click += new System.EventHandler(this.bttnAddNewCalendar_Click);
            // 
            // bttnTestNewCalendar
            // 
            this.bttnTestNewCalendar.Location = new System.Drawing.Point(237, 51);
            this.bttnTestNewCalendar.Name = "bttnTestNewCalendar";
            this.bttnTestNewCalendar.Size = new System.Drawing.Size(75, 23);
            this.bttnTestNewCalendar.TabIndex = 12;
            this.bttnTestNewCalendar.Text = "Test";
            this.bttnTestNewCalendar.UseVisualStyleBackColor = true;
            this.bttnTestNewCalendar.Click += new System.EventHandler(this.bttnTestNewCalendar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Calendar Address";
            // 
            // pbTestingProgress
            // 
            this.pbTestingProgress.Location = new System.Drawing.Point(12, 51);
            this.pbTestingProgress.Name = "pbTestingProgress";
            this.pbTestingProgress.Size = new System.Drawing.Size(219, 23);
            this.pbTestingProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbTestingProgress.TabIndex = 14;
            // 
            // DiagManageCalendars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 340);
            this.Controls.Add(this.pbTestingProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnDeleteSelectedCalendar);
            this.Controls.Add(this.bttnTestNewCalendar);
            this.Controls.Add(this.bttnAddNewCalendar);
            this.Controls.Add(this.tbNewCalendarAddress);
            this.Controls.Add(this.lbEnabledCalendars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDisableCalendar);
            this.Controls.Add(this.bttnEnableCalendar);
            this.Controls.Add(this.lbAvailableCalendars);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiagManageCalendars";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Manage Calendars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiagManageCalendars_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbAvailableCalendars;
        private System.Windows.Forms.Button bttnEnableCalendar;
        private System.Windows.Forms.Button bttnDisableCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEnabledCalendars;
        private System.Windows.Forms.Button bttnDeleteSelectedCalendar;
        private System.Windows.Forms.TextBox tbNewCalendarAddress;
        private System.Windows.Forms.Button bttnAddNewCalendar;
        private System.Windows.Forms.Button bttnTestNewCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbTestingProgress;
    }
}