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
using System.Windows.Forms.VisualStyles;

namespace _2021_CS_140
{
    public partial class ManageEvaluations : Form
    {

        public ManageEvaluations()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignmentOfMultipleAdvisorsToProject_Load(object sender, EventArgs e)
        {

        }

        private void advisorAssignBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into Evaluation values(@Name,@TotalMarks,@TotalWeightage)", con);

                cmd.Parameters.AddWithValue("@Name",textBox1.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage",textBox3.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Evaluated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Required Fields should not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
