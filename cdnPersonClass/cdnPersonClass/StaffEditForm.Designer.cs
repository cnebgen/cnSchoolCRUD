namespace cdnPersonClass
{
    partial class StaffEditForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.stHOD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stBOD = new System.Windows.Forms.TextBox();
            this.stG = new System.Windows.Forms.TextBox();
            this.stlName = new System.Windows.Forms.TextBox();
            this.stfName = new System.Windows.Forms.TextBox();
            this.cmtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Hire Date";
            // 
            // stHOD
            // 
            this.stHOD.Location = new System.Drawing.Point(88, 110);
            this.stHOD.Name = "stHOD";
            this.stHOD.Size = new System.Drawing.Size(127, 20);
            this.stHOD.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // stBOD
            // 
            this.stBOD.Location = new System.Drawing.Point(88, 84);
            this.stBOD.Name = "stBOD";
            this.stBOD.Size = new System.Drawing.Size(127, 20);
            this.stBOD.TabIndex = 23;
            // 
            // stG
            // 
            this.stG.Location = new System.Drawing.Point(88, 58);
            this.stG.Name = "stG";
            this.stG.Size = new System.Drawing.Size(127, 20);
            this.stG.TabIndex = 22;
            // 
            // stlName
            // 
            this.stlName.Location = new System.Drawing.Point(88, 32);
            this.stlName.Name = "stlName";
            this.stlName.Size = new System.Drawing.Size(127, 20);
            this.stlName.TabIndex = 21;
            // 
            // stfName
            // 
            this.stfName.Location = new System.Drawing.Point(88, 6);
            this.stfName.Name = "stfName";
            this.stfName.Size = new System.Drawing.Size(127, 20);
            this.stfName.TabIndex = 20;
            // 
            // cmtBtn
            // 
            this.cmtBtn.Location = new System.Drawing.Point(15, 145);
            this.cmtBtn.Name = "cmtBtn";
            this.cmtBtn.Size = new System.Drawing.Size(200, 23);
            this.cmtBtn.TabIndex = 30;
            this.cmtBtn.Text = "Commit Changes";
            this.cmtBtn.UseVisualStyleBackColor = true;
            this.cmtBtn.Click += new System.EventHandler(this.cmtBtn_Click);
            // 
            // StaffEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 180);
            this.Controls.Add(this.cmtBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stHOD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stBOD);
            this.Controls.Add(this.stG);
            this.Controls.Add(this.stlName);
            this.Controls.Add(this.stfName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffEditForm";
            this.Text = "Edit Form:Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stHOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stBOD;
        private System.Windows.Forms.TextBox stG;
        private System.Windows.Forms.TextBox stlName;
        private System.Windows.Forms.TextBox stfName;
        private System.Windows.Forms.Button cmtBtn;

    }
}