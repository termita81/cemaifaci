namespace CeMaiFaci
{
    partial class LogForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("111111", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("222222", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("333333", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(" dsljf habgdjfh haskfdjhs ldkfjhsldfgs dfgs dfgsh34aw");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("d sadf asgfasdfj3452 2e");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("2 sdfsdfgdfg");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("2 hdfhdfg3h4t3");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("2 gh568krtjfhg");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("2 fdgdfg  sdfg df5yes 5rse5ry drfgsdfg dfg sergvebrgsergvsefg sdfg");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("2  fvhfd56jerhgtsvefg adf dgs gdsf");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("2 56 3aeer rfgdfzg dfgsdfg dfg sd");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "2  fdg3445j3srgsedfs",
            "Sub1",
            "Sub2",
            "Sub3"}, -1);
            this.lvLog = new System.Windows.Forms.ListView();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lvLog
            // 
            listViewGroup1.Header = "111111";
            listViewGroup1.Name = "111111";
            listViewGroup2.Header = "222222";
            listViewGroup2.Name = "222222";
            listViewGroup3.Header = "333333";
            listViewGroup3.Name = "333333";
            this.lvLog.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup2;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup1;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup2;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup2;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Group = listViewGroup2;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.Group = listViewGroup2;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.Group = listViewGroup2;
            listViewItem9.StateImageIndex = 0;
            this.lvLog.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lvLog.Location = new System.Drawing.Point(666, 416);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(401, 138);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.SmallIcon;
            this.lvLog.Visible = false;
            // 
            // rtLog
            // 
            this.rtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtLog.Location = new System.Drawing.Point(0, 0);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(1067, 554);
            this.rtLog.TabIndex = 1;
            this.rtLog.Text = "";
            this.rtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtLog_KeyPress);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtLog);
            this.Controls.Add(this.lvLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogForm";
            this.Text = "Istoric";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.RichTextBox rtLog;
    }
}