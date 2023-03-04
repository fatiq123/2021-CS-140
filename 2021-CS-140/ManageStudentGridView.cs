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
    public partial class ManageStudentGridView : Form
    {
        public ManageStudentGridView()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ManageStudentGridView(DataTable dataTable)
        {
            InitializeComponent();

            dataGridView1.DataSource = dataTable;
        }

    }
}
