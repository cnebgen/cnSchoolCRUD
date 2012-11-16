using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cdnPersonClass
{
    public partial class StudentEditForm : Form
    {
        public Student student = new Student();

        public StudentEditForm(Student s)
        {
            student = s;
            InitializeComponent();
            sFName.Text = student.FirstName;
            sLName.Text = student.LastName;
            sGndr.Text = Convert.ToString(student.Gender);
            sBOD.Text = Convert.ToString(student.Birthdate);
            sMajor.Text = student.Major;
            sGPA.Text = Convert.ToString(student.GradePointAverage);
        }

        private void cmtBtn_Click(object sender, EventArgs e)
        {
            student.FirstName = sFName.Text;
            student.LastName = sLName.Text;
            student.Gender = Convert.ToChar(sGndr.Text);
            student.Birthdate = Convert.ToDateTime(sBOD.Text);
            student.Major = sMajor.Text;
            student.GradePointAverage = Convert.ToDouble(sGPA.Text);
            Close();
        }
       
    }
}
