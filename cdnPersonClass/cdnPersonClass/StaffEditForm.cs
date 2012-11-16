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
    public partial class StaffEditForm : Form
    {
        public Staff staffer = new Staff();

        public StaffEditForm(Staff st)
        {
            staffer = st;
            InitializeComponent();
            stfName.Text = staffer.FirstName;
            stlName.Text = staffer.LastName;
            stG.Text = Convert.ToString(staffer.Gender);
            stBOD.Text = Convert.ToString(staffer.Birthdate);
            stHOD.Text = Convert.ToString(staffer.DateHired);
        }

        private void cmtBtn_Click(object sender, EventArgs e)
        {
            staffer.FirstName = stfName.Text;
            staffer.LastName = stlName.Text;
            staffer.Gender = Convert.ToChar(stG.Text);
            staffer.Birthdate = Convert.ToDateTime(stBOD);
            staffer.DateHired = Convert.ToDateTime(stHOD);
            Close();
        }       

    }
}
