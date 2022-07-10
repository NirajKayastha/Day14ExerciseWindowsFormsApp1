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
    public partial class DisconnectedForm : Form
    {
        private SqlConnection conObj = null;
        private  SqlDataAdapter adapter = null;
        private DataSet  ds = null;
    
        public DisconnectedForm()
        {
            InitializeComponent();
        }

        private void DisconnectedForm_Load(object sender, EventArgs e)
        {
            using (conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnHR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", conObj))
                { 
                  ds = new DataSet();
                    adapter.Fill(ds, "Depart");
                    textBox1.Text = ds.Tables["Depart"].Rows[2]["cDepartmentCode"].ToString();
                    textBox2.Text = ds.Tables["Depart"].Rows[2]["vDepartmentName"].ToString();
                    textBox3.Text = ds.Tables["Depart"].Rows[2]["vDepartmentHead"].ToString();
                    textBox4.Text = ds.Tables["Depart"].Rows[2]["vLocation"].ToString();


                }

            }
                    
        }
    }
}
