namespace cdnPersonClass
{
    partial class TeacherEditForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBOD = new System.Windows.Forms.TextBox();
            this.tG = new System.Windows.Forms.TextBox();
            this.tlName = new System.Windows.Forms.TextBox();
            this.tfName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tHOD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tDept = new System.Windows.Forms.TextBox();
            this.cmtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // tBOD
            // 
            this.tBOD.Location = new System.Drawing.Point(88, 84);
            this.tBOD.Name = "tBOD";
            this.tBOD.Size = new System.Drawing.Size(127, 20);
            this.tBOD.TabIndex = 13;
            // 
            // tG
            // 
            this.tG.Location = new System.Drawing.Point(88, 58);
            this.tG.Name = "tG";
            this.tG.Size = new System.Drawing.Size(127, 20);
            this.tG.TabIndex = 12;
            // 
            // tlName
            // 
            this.tlName.Location = new System.Drawing.Point(88, 32);
            this.tlName.Name = "tlName";
            this.tlName.Size = new System.Drawing.Size(127, 20);
            this.tlName.TabIndex = 11;
            // 
            // tfName
            // 
            this.tfName.Location = new System.Drawing.Point(88, 6);
            this.tfName.Name = "tfName";
            this.tfName.Size = new System.Drawing.Size(127, 20);
            this.tfName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hire Date";
            // 
            // tHOD
            // 
            this.tHOD.Location = new System.Drawing.Point(88, 110);
            this.tHOD.Name = "tHOD";
            this.tHOD.Size = new System.Drawing.Size(127, 20);
            this.tHOD.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Department";
            // 
            // tDept
            // 
            this.tDept.Location = new System.Drawing.Point(88, 136);
            this.tDept.Name = "tDept";
            this.tDept.Size = new System.Drawing.Size(127, 20);
            this.tDept.TabIndex = 20;
            // 
            // cmtBtn
            // 
            this.cmtBtn.Location = new System.Drawing.Point(15, 167);
            this.cmtBtn.Name = "cmtBtn";
            this.cmtBtn.Size = new System.Drawing.Size(200, 23);
            this.cmtBtn.TabIndex = 22;
            this.cmtBtn.Text = "Commit Changes";
            this.cmtBtn.UseVisualStyleBackColor = true;
            this.cmtBtn.Click += new System.EventHandler(this.cmtBtn_Click);
            // 
            // TeacherEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 202);
            this.Controls.Add(this.cmtBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tHOD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBOD);
            this.Controls.Add(this.tG);
            this.Controls.Add(this.tlName);
            this.Controls.Add(this.tfName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherEditForm";
            this.Text = "Edit Form:Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBOD;
        private System.Windows.Forms.TextBox tG;
        private System.Windows.Forms.TextBox tlName;
        private System.Windows.Forms.TextBox tfName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tHOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tDept;
        private System.Windows.Forms.Button cmtBtn;
    }
}