namespace CeMaiFaci
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Group 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Group 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Item 1 1000000 dfg sfg sdfgsdfgsdfgsdfg");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Item 2 1000000");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Item 3 1000000");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Item 4 1000000");
            this.lblTime = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMSTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiShowLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLater = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDo = new System.Windows.Forms.Label();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtFeel = new System.Windows.Forms.TextBox();
            this.lblFeel = new System.Windows.Forms.Label();
            this.grpFeel = new System.Windows.Forms.GroupBox();
            this.lvFeelings = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLog = new System.Windows.Forms.Button();
            this.ctxMSTray.SuspendLayout();
            this.grpFeel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(33, 31);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Este ora ";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Micsorata, dar nu inchisa";
            this.notifyIcon.BalloonTipTitle = "Ce mai faci?";
            this.notifyIcon.ContextMenuStrip = this.ctxMSTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Ce mai faci?";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // ctxMSTray
            // 
            this.ctxMSTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tmsiShowLog,
            this.tmsiQuit});
            this.ctxMSTray.Name = "ctxMSTray";
            this.ctxMSTray.Size = new System.Drawing.Size(151, 70);
            this.ctxMSTray.Text = "Ce mai faci?";
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(150, 22);
            this.tsmiShow.Text = "Arata fereastra";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tmsiShowLog
            // 
            this.tmsiShowLog.Name = "tmsiShowLog";
            this.tmsiShowLog.Size = new System.Drawing.Size(150, 22);
            this.tmsiShowLog.Text = "Arata istoricul";
            this.tmsiShowLog.Click += new System.EventHandler(this.tmsiShowLog_Click);
            // 
            // tmsiQuit
            // 
            this.tmsiQuit.Name = "tmsiQuit";
            this.tmsiQuit.Size = new System.Drawing.Size(150, 22);
            this.tmsiQuit.Text = "Iesi";
            this.tmsiQuit.Click += new System.EventHandler(this.tmsiQuit_Click);
            // 
            // btnLater
            // 
            this.btnLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLater.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLater.Location = new System.Drawing.Point(145, 674);
            this.btnLater.Margin = new System.Windows.Forms.Padding(4);
            this.btnLater.Name = "btnLater";
            this.btnLater.Size = new System.Drawing.Size(100, 28);
            this.btnLater.TabIndex = 1;
            this.btnLater.Text = "Mai incolo...";
            this.btnLater.UseVisualStyleBackColor = true;
            this.btnLater.Click += new System.EventHandler(this.btnLater_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(37, 674);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDo
            // 
            this.lblDo.Location = new System.Drawing.Point(33, 86);
            this.lblDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(200, 16);
            this.lblDo.TabIndex = 3;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(8, 23);
            this.txtDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDo.Multiline = true;
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(523, 64);
            this.txtDo.TabIndex = 4;
            // 
            // txtFeel
            // 
            this.txtFeel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeel.Location = new System.Drawing.Point(8, 388);
            this.txtFeel.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeel.Multiline = true;
            this.txtFeel.Name = "txtFeel";
            this.txtFeel.Size = new System.Drawing.Size(523, 45);
            this.txtFeel.TabIndex = 6;
            // 
            // lblFeel
            // 
            this.lblFeel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFeel.Location = new System.Drawing.Point(8, 368);
            this.lblFeel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeel.Name = "lblFeel";
            this.lblFeel.Size = new System.Drawing.Size(200, 16);
            this.lblFeel.TabIndex = 5;
            this.lblFeel.Text = "Cu cuvintele tale";
            // 
            // grpFeel
            // 
            this.grpFeel.Controls.Add(this.lvFeelings);
            this.grpFeel.Controls.Add(this.txtFeel);
            this.grpFeel.Controls.Add(this.lblFeel);
            this.grpFeel.Location = new System.Drawing.Point(37, 199);
            this.grpFeel.Margin = new System.Windows.Forms.Padding(4);
            this.grpFeel.Name = "grpFeel";
            this.grpFeel.Padding = new System.Windows.Forms.Padding(4);
            this.grpFeel.Size = new System.Drawing.Size(540, 441);
            this.grpFeel.TabIndex = 7;
            this.grpFeel.TabStop = false;
            this.grpFeel.Text = "Cum te simti?";
            // 
            // lvFeelings
            // 
            this.lvFeelings.CheckBoxes = true;
            listViewGroup5.Header = "Group 1";
            listViewGroup5.Name = "Group 1";
            listViewGroup6.Header = "Group 2";
            listViewGroup6.Name = "Group 2";
            this.lvFeelings.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            listViewItem9.Group = listViewGroup5;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup5;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.Group = listViewGroup6;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.Group = listViewGroup6;
            listViewItem12.StateImageIndex = 0;
            this.lvFeelings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvFeelings.Location = new System.Drawing.Point(12, 23);
            this.lvFeelings.Margin = new System.Windows.Forms.Padding(4);
            this.lvFeelings.Name = "lvFeelings";
            this.lvFeelings.Size = new System.Drawing.Size(508, 312);
            this.lvFeelings.TabIndex = 9;
            this.lvFeelings.UseCompatibleStateImageBehavior = false;
            this.lvFeelings.View = System.Windows.Forms.View.SmallIcon;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDo);
            this.groupBox1.Location = new System.Drawing.Point(37, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(540, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ce faci?";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 999999;
            this.tmrTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLog.Location = new System.Drawing.Point(469, 674);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 28);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Istoric";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLater;
            this.ClientSize = new System.Drawing.Size(616, 735);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFeel);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLater);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ce mai faci?";
            this.Resize += new System.EventHandler(this.TheForm_Resize);
            this.ctxMSTray.ResumeLayout(false);
            this.grpFeel.ResumeLayout(false);
            this.grpFeel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnLater;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtFeel;
        private System.Windows.Forms.Label lblFeel;
        private System.Windows.Forms.GroupBox grpFeel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip ctxMSTray;
        private System.Windows.Forms.ToolStripMenuItem tmsiQuit;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.ListView lvFeelings;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.ToolStripMenuItem tmsiShowLog;
    }
}

