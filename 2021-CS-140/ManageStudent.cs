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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable GetDataFromSQL()
        {
            // Establish a connection to your SQL database
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");

            // Create a SQL command to retrieve data from your database
            SqlCommand command = new SqlCommand("SELECT DateOfBirth FROM Person", connection);

            // Execute the command and retrieve the data
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Create a DataTable object to store the data
            DataTable dataTable = new DataTable();

            // Load the data into the DataTable object
            dataTable.Load(reader);

            // Close the connection and dispose of the SqlDataReader object
            reader.Close();
            connection.Close();

            // Return the DataTable object
            return dataTable;
        }


        private void addstudentbtn_Click_1(object sender, EventArgs e)
        {

            //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1 != null && comboBox1 != null)
            //{

                string connectionString = "Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string firstName = "John";
                string lastName = "Doe";
                string contact = "1234567890";
                string email = "johndoe@example.com";
                DateTime dob = new DateTime(1990, 1, 1);
                string regNo = "12345";
                string gender = "Male";
                int genderCode = gender == "Male" ? 0 : 1; // Assuming 0 for Male and 1 for Female



            string insertPersonQuery = "INSERT INTO person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)";
                SqlCommand insertPersonCommand = new SqlCommand(insertPersonQuery, connection);
                insertPersonCommand.Parameters.AddWithValue("@FirstName", firstName);
                insertPersonCommand.Parameters.AddWithValue("@LastName", lastName);
                insertPersonCommand.Parameters.AddWithValue("@Contact", contact);
                insertPersonCommand.Parameters.AddWithValue("@Email", email);
                insertPersonCommand.Parameters.AddWithValue("@DateOfBirth", dob);
                insertPersonCommand.Parameters.AddWithValue("@Gender", Convert.ToInt32(genderCode));
                insertPersonCommand.ExecuteNonQuery();

                string selectLastIdQuery = "SELECT SCOPE_IDENTITY()";
                SqlCommand selectLastIdCommand = new SqlCommand(selectLastIdQuery, connection);
                //int lastId = Convert.ToInt32(selectLastIdCommand.ExecuteScalar());

                string insertStudentQuery = "INSERT INTO student (Id, RegistrationNo) VALUES (@Id, @RegistrationNo)";
                SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
                //insertStudentCommand.Parameters.AddWithValue("@Id", lastId);
                insertStudentCommand.Parameters.AddWithValue("@RegistrationNo", regNo);
                













                //// add values
                //SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
                //con.Open();
                //SqlCommand cmd = new SqlCommand("insert into Person values(@RegistrationNo,@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
                //cmd.Parameters.AddWithValue("@RegistrationNo", textBox1.Text);
                //cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                //cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                //cmd.Parameters.AddWithValue("@Contact", textBox4.Text);
                //cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                ////DateTime date = new DateTime(2023,3,4);
                ////cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value = date);
                ////cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                //cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateTimePicker1.Value.Date;




                                ////string connectionString = "Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True";
                                //using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True"))
                                //{
                                //    connection.Open();
                                //    SqlCommand command = new SqlCommand("SELECT * FROM Person WHERE Gender=@Gender)", connection);
                                //    command.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
                                //    SqlDataReader reader = command.ExecuteReader();
                                //    while (reader.Read())
                                //    {
                                //        comboBox1.Items.Add(reader["GenderName"].ToString());
                                //    }
                                //    reader.Close();
                                //    connection.Close();
                                //}
                                //if (comboBox1.SelectedIndex == -1)
                                //{
                                //    MessageBox.Show("Please select a option from drop down menu");
                                //    comboBox1.Focus();
                                //}




                                //// SqlCommand cmd2 = new SqlCommand("Select MAX(Id) FROM Person", con);
                                ////SqlCommand cmd3 = new SqlCommand("insert into Student values(@Id,@Registrartion)", con);

                                //cmd.ExecuteNonQuery();
                                //string selectLastIdQuery = "SELECT SCOPE_IDENTITY()";
                                //SqlCommand selectLastIdCommand = new SqlCommand(selectLastIdQuery, con);
                                //int lastId = Convert.ToInt32(selectLastIdCommand.ExecuteScalar());



                                //string insertStudentQuery = "INSERT INTO student (id, regNo) VALUES (@id, @regNo)";
                                //SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, con);
                                //insertStudentCommand.Parameters.AddWithValue("@id", lastId);
                                //insertStudentCommand.Parameters.AddWithValue("@regNo", textBox2.Text);
                                //insertStudentCommand.ExecuteNonQuery();



                                ////cmd.ExecuteNonQuery();
                                //con.Close();

                                MessageBox.Show("Student Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Required Fields should not Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void showStudentBtn_Click_1(object sender, EventArgs e)
        {
            ManageStudentGridView m = new ManageStudentGridView(GetDataFromSQL());
            m.Show(this);
        }
    }
}





//string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword";
//SqlConnection connection = new SqlConnection(connectionString);
//connection.Open();

//string insertOrderQuery = "INSERT INTO Orders (OrderId, OrderDate, CustomerId) VALUES (@OrderId, @OrderDate, @CustomerId)";
//SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
//insertOrderCommand.Parameters.AddWithValue("@OrderId", orderId);
//insertOrderCommand.Parameters.AddWithValue("@OrderDate", orderDate);
//insertOrderCommand.Parameters.AddWithValue("@CustomerId", customerId);
//insertOrderCommand.ExecuteNonQuery();

//string insertOrderDetailsQuery = "INSERT INTO OrderDetails (OrderId, ProductId, Quantity) VALUES (@OrderId, @ProductId, @Quantity)";
//SqlCommand insertOrderDetailsCommand = new SqlCommand(insertOrderDetailsQuery, connection);
//insertOrderDetailsCommand.Parameters.AddWithValue("@OrderId", orderId);
//insertOrderDetailsCommand.Parameters.AddWithValue("@ProductId", productId);
//insertOrderDetailsCommand.Parameters.AddWithValue("@Quantity", quantity);
//insertOrderDetailsCommand.ExecuteNonQuery();

//connection.Close();








//string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword";
//SqlConnection connection = new SqlConnection(connectionString);
//connection.Open();

//string firstName = "John";
//string lastName = "Doe";
//string contact = "1234567890";
//string email = "johndoe@example.com";
//DateTime dob = new DateTime(1990, 1, 1);
//string gender = "Male";
//string regNo = "12345";

//string insertPersonQuery = "INSERT INTO person (first_name, last_name, contact, email, dateOfBirth, gender) VALUES (@firstName, @lastName, @contact, @email, @dob, @gender)";
//SqlCommand insertPersonCommand = new SqlCommand(insertPersonQuery, connection);
//insertPersonCommand.Parameters.AddWithValue("@firstName", firstName);
//insertPersonCommand.Parameters.AddWithValue("@lastName", lastName);
//insertPersonCommand.Parameters.AddWithValue("@contact", contact);
//insertPersonCommand.Parameters.AddWithValue("@email", email);
//insertPersonCommand.Parameters.AddWithValue("@dob", dob);
//insertPersonCommand.Parameters.AddWithValue("@gender", gender);
//insertPersonCommand.ExecuteNonQuery();

//string selectLastIdQuery = "SELECT SCOPE_IDENTITY()";
//SqlCommand selectLastIdCommand = new SqlCommand(selectLastIdQuery, connection);
//int lastId = Convert.ToInt32(selectLastIdCommand.ExecuteScalar());

//string insertStudentQuery = "INSERT INTO student (id, regNo) VALUES (@id, @regNo)";
//SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
//insertStudentCommand.Parameters.AddWithValue("@id", lastId