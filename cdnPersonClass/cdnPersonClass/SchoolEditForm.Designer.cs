namespace cdnPersonClass
{
    partial class SchoolEditForm
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
            this.staffTab = new System.Windows.Forms.TabPage();
            this.lbStaff = new System.Windows.Forms.ListBox();
            this.teacherTab = new System.Windows.Forms.TabPage();
            this.lbTeach = new System.Windows.Forms.ListBox();
            this.stuTab = new System.Windows.Forms.TabPage();
            this.lbStu = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stuCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tchrCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stfCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffTab.SuspendLayout();
            this.teacherTab.SuspendLayout();
            this.stuTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.stuCM.SuspendLayout();
            this.tchrCM.SuspendLayout();
            this.stfCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffTab
            // 
            this.staffTab.Controls.Add(this.lbStaff);
            this.staffTab.Location = new System.Drawing.Point(4, 22);
            this.staffTab.Name = "staffTab";
            this.staffTab.Padding = new System.Windows.Forms.Padding(3);
            this.staffTab.Size = new System.Drawing.Size(348, 327);
            this.staffTab.TabIndex = 2;
            this.staffTab.Text = "Staff";
            this.staffTab.UseVisualStyleBackColor = true;
            // 
            // lbStaff
            // 
            this.lbStaff.ContextMenuStrip = this.stfCM;
            this.lbStaff.FormattingEnabled = true;
            this.lbStaff.Location = new System.Drawing.Point(0, 0);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(348, 329);
            this.lbStaff.TabIndex = 1;
            this.lbStaff.SelectedIndexChanged += new System.EventHandler(this.lbStaff_SelectedIndexChanged_1);
            // 
            // teacherTab
            // 
            this.teacherTab.Controls.Add(this.lbTeach);
            this.teacherTab.Location = new System.Drawing.Point(4, 22);
            this.teacherTab.Name = "teacherTab";
            this.teacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.teacherTab.Size = new System.Drawing.Size(348, 327);
            this.teacherTab.TabIndex = 1;
            this.teacherTab.Text = "Teachers";
            this.teacherTab.UseVisualStyleBackColor = true;
            // 
            // lbTeach
            // 
            this.lbTeach.ContextMenuStrip = this.tchrCM;
            this.lbTeach.FormattingEnabled = true;
            this.lbTeach.Location = new System.Drawing.Point(0, 0);
            this.lbTeach.Name = "lbTeach";
            this.lbTeach.Size = new System.Drawing.Size(348, 329);
            this.lbTeach.TabIndex = 1;
            this.lbTeach.SelectedIndexChanged += new System.EventHandler(this.lbTeach_SelectedIndexChanged_1);
            // 
            // stuTab
            // 
            this.stuTab.Controls.Add(this.lbStu);
            this.stuTab.Location = new System.Drawing.Point(4, 22);
            this.stuTab.Name = "stuTab";
            this.stuTab.Padding = new System.Windows.Forms.Padding(3);
            this.stuTab.Size = new System.Drawing.Size(348, 327);
            this.stuTab.TabIndex = 0;
            this.stuTab.Text = "Students";
            this.stuTab.UseVisualStyleBackColor = true;
            // 
            // lbStu
            // 
            this.lbStu.ContextMenuStrip = this.stuCM;
            this.lbStu.FormattingEnabled = true;
            this.lbStu.Location = new System.Drawing.Point(0, 0);
            this.lbStu.Name = "lbStu";
            this.lbStu.Size = new System.Drawing.Size(348, 329);
            this.lbStu.TabIndex = 0;
            this.lbStu.SelectedIndexChanged += new System.EventHandler(this.lbStu_SelectedIndexChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stuTab);
            this.tabControl1.Controls.Add(this.teacherTab);
            this.tabControl1.Controls.Add(this.staffTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // stuCM
            // 
            this.stuCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.stuCM.Name = "stuCM";
            this.stuCM.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // tchrCM
            // 
            this.tchrCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.tchrCM.Name = "tchrCM";
            this.tchrCM.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "&Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem1.Text = "&Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // stfCM
            // 
            this.stfCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.removeToolStripMenuItem2});
            this.stfCM.Name = "stfCM";
            this.stfCM.Size = new System.Drawing.Size(153, 70);
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem2.Text = "&Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // removeToolStripMenuItem2
            // 
            this.removeToolStripMenuItem2.Name = "removeToolStripMenuItem2";
            this.removeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem2.Text = "&Remove";
            this.removeToolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem2_Click);
            // 
            // SchoolEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 378);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchoolEditForm";
            this.Text = "School App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchoolEditForm_FormClosed);
            this.Load += new System.EventHandler(this.SchoolEditForm_Load);
            this.staffTab.ResumeLayout(false);
            this.teacherTab.ResumeLayout(false);
            this.stuTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.stuCM.ResumeLayout(false);
            this.tchrCM.ResumeLayout(false);
            this.stfCM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage staffTab;
        private System.Windows.Forms.ListBox lbStaff;
        private System.Windows.Forms.TabPage teacherTab;
        private System.Windows.Forms.ListBox lbTeach;
        private System.Windows.Forms.TabPage stuTab;
        private System.Windows.Forms.ListBox lbStu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip stuCM;
        private System.Windows.Forms.ContextMenuStrip stfCM;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip tchrCM;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}