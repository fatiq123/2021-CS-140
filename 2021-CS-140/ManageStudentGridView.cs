using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _2021_CS_140
{
    public partial class ManageStudentGridView : Form
    {
        // to make it global
        private DataTable stdDataTable = new DataTable();

        public ManageStudentGridView()
        {
            InitializeComponent();
        }

        public ManageStudentGridView(DataTable dataTable)
        {
            InitializeComponent();

           // dataGridView1.DataSource = dataTable;
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageStudentForm_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");

            // create a SqlCommand object
            SqlCommand cmd = new SqlCommand("Select p.Id,p.FirstName,p.LastName,p.Contact,p.Email,p.DateOfBirth,p.Gender,s.RegistrationNo From Person p join Student s on p.Id = s.Id", con);

            // create a SqlDataAdapter object
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // create a DataTable object
            DataTable dt = new DataTable();

            // fill the DataTable with data from the database
            da.Fill(dt);

            // set the DataGridView's DataSource property to the DataTable
            dataGridView1.DataSource = dt;
        }

        private void searchStudentBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from person join student where person.FirstName like '" + TextBox1.Text + "%'");
            // string query = "select * from emp where Name like '" + TextBox1.Text + "%'";
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataBind();
         
        }

        private void studentSearchBox_TextChanged(object sender, EventArgs e)
        {

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Email Like '%" + studentSearchBox.Text + "%'");

        }

        private void studentUpdateBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
            //for (int item=0; item<=dataGridView1.Rows.Count-1; item++)
            //{
            //    int id = 1;
            //    SqlCommand cmd = new SqlCommand("UPDATE Person set FirstName=@FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender WHERE Id=@id",con);
            //    cmd.Parameters.AddWithValue("@FirstName", dataGridView1.Rows[item].Cells[1].Value);
            //    cmd.Parameters.AddWithValue("@LastName", dataGridView1.Rows[item].Cells[2].Value);
            //    cmd.Parameters.AddWithValue("@Contact", dataGridView1.Rows[item].Cells[3].Value);
            //    cmd.Parameters.AddWithValue("@Email", dataGridView1.Rows[item].Cells[4].Value);
            //    cmd.Parameters.AddWithValue("@DateOfBirth", dataGridView1.Rows[item].Cells[5].Value);
            //    cmd.Parameters.AddWithValue("@Gender", dataGridView1.Rows[item].Cells[6].Value);
            //    cmd.Parameters.AddWithValue("@Id",id);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //MessageBox.Show("Rows Updated Successfuly");




            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
            for (int item = 0; item <= dataGridView1.Rows.Count - 1; item++)
            {
                int id1 = 1,id2=2;
                string query1 = "UPDATE Person SET FirstName = @FirstName,LastName = @LastName,Email = @Email, Contact = @Contact, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Id = @Id";
                string query2 = "UPDATE Student SET RegistrationNo = @RegistrationNo WHERE Id = @Id";
              
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command1 = new SqlCommand(query1, connection, transaction);
                SqlCommand command2 = new SqlCommand(query2, connection, transaction);

                command2.Parameters.AddWithValue("@RegistrationNo", dataGridView1.Rows[item].Cells[1].Value);
                command2.Parameters.AddWithValue("@Id", id2);
                command2.ExecuteNonQuery();

                command1.Parameters.AddWithValue("@FirstName", dataGridView1.Rows[item].Cells[2].Value);
                command1.Parameters.AddWithValue("@LastName", dataGridView1.Rows[item].Cells[3].Value);
                command1.Parameters.AddWithValue("@Contact", dataGridView1.Rows[item].Cells[4].Value);
                command1.Parameters.AddWithValue("@Email", dataGridView1.Rows[item].Cells[5].Value);
                command1.Parameters.AddWithValue("@DateOfBirth", dataGridView1.Rows[item].Cells[6].Value);
                command1.Parameters.AddWithValue("@Gender", dataGridView1.Rows[item].Cells[7].Value);
                command1.Parameters.AddWithValue("@Id", id1);
                command1.ExecuteNonQuery();


                connection.Close();

            }



        }

        private void studentDeleteBtn_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dataGridView1.DataKeys[e.RowIndex].Values["Id"]);
            //string connectionString = ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True"].ConnectionString;

            //using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True"))
            //{
            //    connection.Open();

            //    // delete the record from the first table
            //    string deleteFirstTableQuery = "DELETE FROM Student WHERE Id = @Id";
            //    SqlCommand deleteFirstTableCommand = new SqlCommand(deleteFirstTableQuery, connection);
            //    deleteFirstTableCommand.Parameters.AddWithValue("@Id", id);
            //    deleteFirstTableCommand.ExecuteNonQuery();

            //    // delete related records from the second table
            //    string deleteSecondTableQuery = "DELETE FROM Person WHERE Id = @Id";
            //    SqlCommand deleteSecondTableCommand = new SqlCommand(deleteSecondTableQuery, connection);
            //    deleteSecondTableCommand.Parameters.AddWithValue("@Id", id);
            //    deleteSecondTableCommand.ExecuteNonQuery();
            //}

            //// update the GridView
            //dataGridView1.DataBind();



        }
    }
}
