using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_CS_140
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void manageStudentBtn_Click(object sender, EventArgs e)
        {
            ManageStudent s = new ManageStudent();
            s.Show();
        }

        private void manageAdvisorsBtn_Click(object sender, EventArgs e)
        {
            ManageAdvisor a  = new ManageAdvisor();
            a.Show();
        }

        private void manageProjectsBtn_Click(object sender, EventArgs e)
        {
            ManageProject p = new ManageProject();
            p.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
