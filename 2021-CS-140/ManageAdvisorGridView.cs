using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_CS_140
{
    public partial class ManageAdvisorGridView : Form
    {
        public ManageAdvisorGridView()
        {
            InitializeComponent();
        }

        private void advisorCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageStudentForm_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");

            // create a SqlCommand object
            SqlCommand cmd = new SqlCommand("Select p.Id,p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,a.Designation,a.Salary From Person p join Advisor a on p.Id = a.Id", con);

            // create a SqlDataAdapter object
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // create a DataTable object
            DataTable dt = new DataTable();

            // fill the DataTable with data from the database
            da.Fill(dt);

            // set the DataGridView's DataSource property to the DataTable
            dataGridView2.DataSource = dt;
        }

    }
}
