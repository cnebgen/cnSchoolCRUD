namespace cdnPersonClass
{
    partial class StudentEditForm
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
            this.sFName = new System.Windows.Forms.TextBox();
            this.sLName = new System.Windows.Forms.TextBox();
            this.sGndr = new System.Windows.Forms.TextBox();
            this.sBOD = new System.Windows.Forms.TextBox();
            this.sMajor = new System.Windows.Forms.TextBox();
            this.sGPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sFName
            // 
            this.sFName.Location = new System.Drawing.Point(88, 13);
            this.sFName.Name = "sFName";
            this.sFName.Size = new System.Drawing.Size(127, 20);
            this.sFName.TabIndex = 0;
            // 
            // sLName
            // 
            this.sLName.Location = new System.Drawing.Point(88, 39);
            this.sLName.Name = "sLName";
            this.sLName.Size = new System.Drawing.Size(127, 20);
            this.sLName.TabIndex = 1;
            // 
            // sGndr
            // 
            this.sGndr.Location = new System.Drawing.Point(88, 65);
            this.sGndr.Name = "sGndr";
            this.sGndr.Size = new System.Drawing.Size(127, 20);
            this.sGndr.TabIndex = 2;
            // 
            // sBOD
            // 
            this.sBOD.Location = new System.Drawing.Point(88, 91);
            this.sBOD.Name = "sBOD";
            this.sBOD.Size = new System.Drawing.Size(127, 20);
            this.sBOD.TabIndex = 3;
            // 
            // sMajor
            // 
            this.sMajor.Location = new System.Drawing.Point(88, 117);
            this.sMajor.Name = "sMajor";
            this.sMajor.Size = new System.Drawing.Size(127, 20);
            this.sMajor.TabIndex = 4;
            // 
            // sGPA
            // 
            this.sGPA.Location = new System.Drawing.Point(88, 143);
            this.sGPA.Name = "sGPA";
            this.sGPA.Size = new System.Drawing.Size(127, 20);
            this.sGPA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Major";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "GPA";
            // 
            // cmtBtn
            // 
            this.cmtBtn.Location = new System.Drawing.Point(15, 172);
            this.cmtBtn.Name = "cmtBtn";
            this.cmtBtn.Size = new System.Drawing.Size(200, 23);
            this.cmtBtn.TabIndex = 12;
            this.cmtBtn.Text = "Commit Changes";
            this.cmtBtn.UseVisualStyleBackColor = true;
            this.cmtBtn.Click += new System.EventHandler(this.cmtBtn_Click);
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 207);
            this.Controls.Add(this.cmtBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sGPA);
            this.Controls.Add(this.sMajor);
            this.Controls.Add(this.sBOD);
            this.Controls.Add(this.sGndr);
            this.Controls.Add(this.sLName);
            this.Controls.Add(this.sFName);
            this.Name = "StudentEditForm";
            this.Text = "Edit Form:Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox sFName;
        private System.Windows.Forms.TextBox sLName;
        private System.Windows.Forms.TextBox sGndr;
        private System.Windows.Forms.TextBox sBOD;
        private System.Windows.Forms.TextBox sMajor;
        private System.Windows.Forms.TextBox sGPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmtBtn;
    }
}