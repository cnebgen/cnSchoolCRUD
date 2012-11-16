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
    public partial class TeacherEditForm : Form
    {
        public Teacher teacher = new Teacher();

        public TeacherEditForm(Teacher t)
        {
            teacher = t;
            InitializeComponent();
            tfName.Text = teacher.FirstName;
            tlName.Text = teacher.LastName;
            tG.Text = Convert.ToString(teacher.Gender);
            tBOD.Text = Convert.ToString(teacher.Birthdate);
            tHOD.Text = Convert.ToString(teacher.DateHired);
            tDept.Text = teacher.Department;
        }

        private void cmtBtn_Click(object sender, EventArgs e)
        {
            teacher.FirstName = tfName.Text;
            teacher.LastName = tlName.Text;
            teacher.Gender = Convert.ToChar(tG.Text);
            teacher.Birthdate = Convert.ToDateTime(tBOD.Text);
            teacher.DateHired = Convert.ToDateTime(tHOD.Text);
            teacher.Department = tDept.Text;
            Close();
        }
    }
}
