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

namespace Day14ExerciseWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-6FIM74JD\SQLEXPRESS; Initial Catalog=Training; Integrated Security=true;");


            cmd = new SqlCommand("Select Stud_Code,Stud_Name,Dept_Code,Stud_Dob,Address from Student_master", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            //
            //Stud_Code Stud_Name Dept_Code Stud_Dob Address

            txtStud_Code.Text = reader["Stud_Code"].ToString();
            txtStud_Name.Text = reader["Stud_Name"].ToString();
            txtDept_Code.Text = reader["Dept_Code"].ToString();
            txtStud_Dob.Text = reader["Stud_Dob"].ToString();
            txtAddress.Text = reader["Address"].ToString();

            reader.Close();

            cmd.Dispose();

            con.Close();
        }

     
        public void ClearTextBox()
        {
            txtStud_Code.Text = "";
            txtStud_Name.Text = "";
            txtDept_Code.Clear();
            txtStud_Dob.Text = "";
            txtAddress.Text = "";

            txtStud_Code.Focus();
        }
        //    Stud_Code Stud_Name Dept_Code Stud_Dob Address
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddNewStudent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Stud_Code", txtStud_Code.Text);
                    cmd.Parameters.AddWithValue("@Stud_Name", txtStud_Name.Text);
                    cmd.Parameters.AddWithValue("@Dept_Code", txtDept_Code.Text);
                    cmd.Parameters.AddWithValue("@Stud_Dob", txtStud_Dob.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("New Student Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_UpdateStudentDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Stud_Code", txtStud_Code.Text);
                    cmd.Parameters.AddWithValue("@Stud_Name", txtStud_Name.Text);
                   // cmd.Parameters.AddWithValue("@City", txtDept_Code.Text);
                  //  cmd.Parameters.AddWithValue("@State", txtStud_Dob.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully");
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            this.ClearTextBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (con = new SqlConnection(@"Data Source=LAPTOP-6FIM74JD\SQLEXPRESS; Initial Catalog=Training; Integrated Security=true;"))
            using (cmd = new SqlCommand("Select Stud_Code,Stud_Name,Dept_Code,Stud_Dob,Address from Student_master  Where Stud_Code=@Stud_Code", con))
            {
                cmd.Parameters.AddWithValue("@Stud_Code", txtStud_Code.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                using (reader = cmd.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        reader.Read();
                    
                        txtStud_Name.Text = reader["Stud_Name"].ToString();
                        txtDept_Code.Text = reader["Dept_Code"].ToString();
                        txtStud_Dob.Text = reader["Stud_Dob"].ToString();
                        txtAddress.Text = reader["Address"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No record found");
                        this.ClearTextBox();
                    }


                }

            }
        }
    }
}
