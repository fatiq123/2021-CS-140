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
    public partial class ManageProject : Form
    {
        public ManageProject()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            if (descriptionBtn.Text != "" && titleBtn.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Advisor values(@Description,@Title)", con);
                cmd.Parameters.AddWithValue("@Description", descriptionBtn.Text);
                cmd.Parameters.AddWithValue("@Title", titleBtn.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Project Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Required Fields should not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
