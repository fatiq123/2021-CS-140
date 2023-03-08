﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_CS_140
{
    public partial class FormationOfStudentgroup : Form
    {
        private int roleId=0;
        
        public FormationOfStudentgroup()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStudentGroup c = new CreateStudentGroup();
            c.Show();
        }

        private void addStudentGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K54JBCF;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Select Id FROM Lookup WHERE Value = 'Active'", con);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                roleId = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            cmd1.Dispose();


            //SqlCommand cmd = new SqlCommand("Insert into GroupStudent Values(@GroupId,@StudentId,@Status,@AssignmentDate)",con);
            
            SqlCommand cmd = new SqlCommand("Insert into [GroupStudent] Values (@GroupId,@StudentId,@Status,@AssignmentDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Status", roleId);
            cmd.Parameters.Add("@AssignmentDate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Student Group Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}