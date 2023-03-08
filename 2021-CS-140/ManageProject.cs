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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Project values(@Description,@Title)", con);
                cmd.Parameters.AddWithValue("@Description", textBox1.Text);
                cmd.Parameters.AddWithValue("@Title", textBox2.Text);

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




//if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && dateTimePicker1 != null && comboBox1 != null)
//{
//    SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
//    con.Open();

//    // add values             
//    SqlCommand cmd = new SqlCommand("insert into Person values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
//    cmd.Parameters.AddWithValue("@FirstName", textBox3.Text);
//    cmd.Parameters.AddWithValue("@LastName", textBox4.Text);
//    cmd.Parameters.AddWithValue("@Contact", textBox5.Text);
//    cmd.Parameters.AddWithValue("@Email", textBox6.Text);
//    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateTimePicker1.Value.Date;


//    //string connectionString = "Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True";

//    if (comboBox1.SelectedIndex == -1)
//    {
//        MessageBox.Show("Please select a option from drop down menu");
//        comboBox1.Focus();
//    }
//    int gender;
//    if (comboBox1.SelectedIndex == 0)
//    {
//        gender = 1;
//    }
//    else
//    {
//        gender = 2;
//    }

//    cmd.Parameters.AddWithValue("@Gender", gender);
//    cmd.ExecuteNonQuery();

//    string insertAdvisorQuery = "insert into Advisor (Id,Designation,Salary) Values((SELECT MAX(Id) FROM Person),@Designation,@Salary)";
//    SqlCommand insertAadvisorQuery = new SqlCommand(insertAdvisorQuery, con);

//    SqlCommand command = new SqlCommand("SELECT dbo.ConvertDesignationToInt(@Designation)", con);
//    command.Parameters.AddWithValue("@Designation", textBox1.Text);
//    int designationId = (int)command.ExecuteScalar();

//    //insertAdvisorCommand.Parameters.AddWithValue("@Designation", textBox1.Text);
//    insertAdvisorQuery.Parameters.AddWithValue("@Salary", textBox2.Text);
//    insertAdvisorQuery.ExecuteNonQuery();

//    con.Close();

//    MessageBox.Show("Advisor Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}
//else
//{
//    MessageBox.Show("Required Fields should not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

//}