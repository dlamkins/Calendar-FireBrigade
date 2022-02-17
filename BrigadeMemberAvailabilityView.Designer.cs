
namespace CalendarFireBrigade {
    partial class BrigadeMemberAvailabilityView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.clrStatus = new System.Windows.Forms.Panel();
            this.cmsTeamMemberActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopySchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMarkOoo = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCallNumber = new System.Windows.Forms.Label();
            this.ttEventInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cmsSlotActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSlotName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopySubjectLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenInOutlook = new System.Windows.Forms.ToolStripMenuItem();
            this.clrStatus.SuspendLayout();
            this.cmsTeamMemberActions.SuspendLayout();
            this.cmsSlotActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Fire Fighter";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clrStatus
            // 
            this.clrStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clrStatus.ContextMenuStrip = this.cmsTeamMemberActions;
            this.clrStatus.Controls.Add(this.lblCallNumber);
            this.clrStatus.Controls.Add(this.lblName);
            this.clrStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.clrStatus.Location = new System.Drawing.Point(0, 0);
            this.clrStatus.Name = "clrStatus";
            this.clrStatus.Size = new System.Drawing.Size(200, 39);
            this.clrStatus.TabIndex = 2;
            // 
            // cmsTeamMemberActions
            // 
            this.cmsTeamMemberActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopySchedule,
            this.toolStripSeparator1,
            this.tsmiMarkOoo});
            this.cmsTeamMemberActions.Name = "cmsTeamMemberActions";
            this.cmsTeamMemberActions.Size = new System.Drawing.Size(223, 54);
            // 
            // tsmiCopySchedule
            // 
            this.tsmiCopySchedule.Name = "tsmiCopySchedule";
            this.tsmiCopySchedule.Size = new System.Drawing.Size(222, 22);
            this.tsmiCopySchedule.Text = "Copy Schedule to Clipboard";
            this.tsmiCopySchedule.Click += new System.EventHandler(this.tsmiCopySchedule_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // tsmiMarkOoo
            // 
            this.tsmiMarkOoo.Enabled = false;
            this.tsmiMarkOoo.Name = "tsmiMarkOoo";
            this.tsmiMarkOoo.Size = new System.Drawing.Size(222, 22);
            this.tsmiMarkOoo.Text = "Mark OOO (WIP)";
            // 
            // lblCallNumber
            // 
            this.lblCallNumber.BackColor = System.Drawing.Color.White;
            this.lblCallNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCallNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallNumber.Location = new System.Drawing.Point(-1, -1);
            this.lblCallNumber.Name = "lblCallNumber";
            this.lblCallNumber.Size = new System.Drawing.Size(40, 40);
            this.lblCallNumber.TabIndex = 1;
            this.lblCallNumber.Text = "4";
            this.lblCallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttEventInfo
            // 
            this.ttEventInfo.UseAnimation = false;
            this.ttEventInfo.UseFading = false;
            // 
            // cmsSlotActions
            // 
            this.cmsSlotActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSlotName,
            this.tsmiCopySubjectLine,
            this.toolStripSeparator2,
            this.tsmiOpenInOutlook});
            this.cmsSlotActions.Name = "cmsTeamMemberActions";
            this.cmsSlotActions.Size = new System.Drawing.Size(195, 76);
            // 
            // tsmiSlotName
            // 
            this.tsmiSlotName.Enabled = false;
            this.tsmiSlotName.Name = "tsmiSlotName";
            this.tsmiSlotName.Size = new System.Drawing.Size(194, 22);
            this.tsmiSlotName.Text = "SLOTNAME";
            // 
            // tsmiCopySubjectLine
            // 
            this.tsmiCopySubjectLine.Name = "tsmiCopySubjectLine";
            this.tsmiCopySubjectLine.Size = new System.Drawing.Size(194, 22);
            this.tsmiCopySubjectLine.Text = "Copy Subject Line";
            this.tsmiCopySubjectLine.Click += new System.EventHandler(this.tsmiCopySubjectLine_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // tsmiOpenInOutlook
            // 
            this.tsmiOpenInOutlook.Name = "tsmiOpenInOutlook";
            this.tsmiOpenInOutlook.Size = new System.Drawing.Size(194, 22);
            this.tsmiOpenInOutlook.Text = "Open Event in Outlook";
            this.tsmiOpenInOutlook.Click += new System.EventHandler(this.tsmiOpenInOutlook_Click);
            // 
            // BrigadeMemberAvailabilityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clrStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BrigadeMemberAvailabilityView";
            this.Size = new System.Drawing.Size(200, 226);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BrigadeMemberAvailabilityView_MouseClick);
            this.MouseLeave += new System.EventHandler(this.BrigadeMemberAvailabilityView_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrigadeMemberAvailabilityView_MouseMove);
            this.clrStatus.ResumeLayout(false);
            this.cmsTeamMemberActions.ResumeLayout(false);
            this.cmsSlotActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel clrStatus;
        private System.Windows.Forms.Label lblCallNumber;
        private System.Windows.Forms.ToolTip ttEventInfo;
        private System.Windows.Forms.ContextMenuStrip cmsTeamMemberActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarkOoo;
        private System.Windows.Forms.ContextMenuStrip cmsSlotActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopySchedule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopySubjectLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenInOutlook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSlotName;
    }
}
