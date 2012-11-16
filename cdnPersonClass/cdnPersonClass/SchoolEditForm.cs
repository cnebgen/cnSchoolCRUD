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
    public partial class SchoolEditForm : Form
    {
        public SchoolEditForm()
        {
            InitializeComponent();
        }

        private void SchoolEditForm_Load(object sender, EventArgs e)
        {
            foreach (Student student in Program.school1.Students)
            {
                lbStu.Items.Add(student.FirstName + " " + student.LastName);
            }
            foreach (Teacher teacher in Program.school1.Teachers)
            {
                lbTeach.Items.Add(teacher.FirstName + " " + teacher.LastName);
            }
            foreach (Staff staffer in Program.school1.StaffIs)
            {
                lbStaff.Items.Add(staffer.FirstName + " " + staffer.LastName);
            }
        }

        private void lbStu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbStu.SelectedIndex >= 0 && lbStu.SelectedIndex < Program.school1.Students.Count())
            {
                MessageBox.Show(lbStu.SelectedIndex.ToString());
                StudentEditForm form = new StudentEditForm(Program.school1.Students[lbStu.SelectedIndex]);
                Program.school1.Students[lbStu.SelectedIndex] = form.student;
                form.Show();
                lbStu.Items.Clear();
                foreach (Student student in Program.school1.Students)
                {
                    lbStu.Items.Add(student.FirstName + " " + student.LastName);
                }
            }
            else
            {
                lbStu.SelectedIndex = Program.school1.Students.Count;
                MessageBox.Show(lbStu.SelectedIndex.ToString());
                StudentEditForm form = new StudentEditForm(Program.school1.Students[lbStu.SelectedIndex]);
                Program.school1.Students[lbStu.SelectedIndex] = form.student;
                form.Show();
                lbStu.Items.Clear();
                foreach (Student student in Program.school1.Students)
                {
                    lbStu.Items.Add(student.FirstName + " " + student.LastName);
                }
            }
        }

        private void lbTeach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbTeach.SelectedIndex >= 0 && lbTeach.SelectedIndex < Program.school1.Teachers.Count())
            {
                TeacherEditForm tform = new TeacherEditForm(Program.school1.Teachers[lbTeach.SelectedIndex]);
                Program.school1.Teachers[lbTeach.SelectedIndex] = tform.teacher;
                tform.Show();
                lbTeach.Items.Clear();
                foreach (Teacher teacher in Program.school1.Teachers)
                {
                    lbTeach.Items.Add(teacher.FirstName + " " + teacher.LastName);
                }
            }
            else
            {
                lbTeach.SelectedIndex = Program.school1.Teachers.Count;
                TeacherEditForm tform = new TeacherEditForm(Program.school1.Teachers[lbTeach.SelectedIndex]);
                Program.school1.Teachers[lbTeach.SelectedIndex] = tform.teacher;
                tform.Show();
                lbTeach.Items.Clear();
                foreach (Teacher teacher in Program.school1.Teachers)
                {
                    lbTeach.Items.Add(teacher.FirstName + " " + teacher.LastName);
                }
            }
        }

        private void lbStaff_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbStaff.SelectedIndex >= 0 && lbStaff.SelectedIndex < Program.school1.StaffIs.Count())
            {
                StaffEditForm stform = new StaffEditForm(Program.school1.StaffIs[lbStaff.SelectedIndex]);
                Program.school1.StaffIs[lbStaff.SelectedIndex] = stform.staffer;
                stform.Show();
                lbStaff.Items.Clear();
                foreach (Staff staffer in Program.school1.StaffIs)
                {
                    lbStaff.Items.Add(staffer.FirstName + " " + staffer.LastName);
                }
            }
            else
            {
                lbStaff.SelectedIndex = Program.school1.StaffIs.Count;
                StaffEditForm stform = new StaffEditForm(Program.school1.StaffIs[lbStaff.SelectedIndex]);
                Program.school1.StaffIs[lbStaff.SelectedIndex] = stform.staffer;
                stform.Show();
                lbStaff.Items.Clear();
                foreach (Staff staffer in Program.school1.StaffIs)
                {
                    lbStaff.Items.Add(staffer.FirstName + " " + staffer.LastName);
                }
            }
        }

        private void SchoolEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.SerializeTheData();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEditForm stuForm = new StudentEditForm(new Student());
            stuForm.Show();
            Program.school1.Students.Add(stuForm.student);
            lbStu.Items.Clear();
            foreach (Student student in Program.school1.Students)
            {
                lbStu.Items.Add(student.FirstName + " " + student.LastName);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student Remove");

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherEditForm tForm = new TeacherEditForm(new Teacher());
            tForm.Show();
            Program.school1.Teachers.Add(tForm.teacher);
            lbTeach.Items.Clear();
            foreach (Teacher Teacher in Program.school1.Teachers)
            {
                lbStu.Items.Add(Teacher.FirstName + " " + Teacher.LastName);
            }

        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teacher Remove");
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StaffEditForm stfForm = new StaffEditForm(new Staff());
            stfForm.Show();
            Program.school1.StaffIs.Add(stfForm.staffer);            
            lbStaff.Items.Clear();
            foreach (Staff staffer in Program.school1.StaffIs)
            {
                lbStaff.Items.Add(staffer.FirstName + " " + staffer.LastName);
            }
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Remove");
        }

    }
}
