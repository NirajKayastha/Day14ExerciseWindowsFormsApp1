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
using System.Configuration;

namespace Day14ExerciseWindowsFormsApp
{
    public partial class FormCrudOperations : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        private CurrencyManager cmgr = null;
        private DataRowView drv = null;

        public FormCrudOperations()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connHR"].ConnectionString))
            {
                using (adapter =new SqlDataAdapter("Select * from Department",con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    GridDepartment.DataSource = ds.Tables["Department"];

                }
            }
        }

        private void FormCrudOperations_Load(object sender, EventArgs e)
        {
              this.RefreshTable();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connHR"].ConnectionString)) 
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                { 
                   ds=new DataSet();
                    adapter.Fill(ds, "Department");
                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["cDepartmentCode"]=txtDepartmentCode.Text;
                    dr["vDepartmentName"] = txtDepartmentName.Text;
                    dr["vDepartmentHead"] = txtDepartmentHead.Text;
                    dr["vLocation"]=txtLocation.Text;

                    ds.Tables["Department"].Rows.Add(dr);
                    
                    adapter.Update(ds,"Department");

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connHR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                  
                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                   
                    DataRow dr = ds.Tables["Department"].Rows.Find(txtDepartmentCode.Text);

                    dr.Delete();
                   
                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connHR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");


                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;


                    DataRow dr = ds.Tables["Department"].Rows.Find(txtDepartmentCode.Text);
                  

                    cmgr = (CurrencyManager)GridDepartment.BindingContext[ds.Tables[0]];//Currencymgr class managing and binding objects
                    try
                    {
                        DataView dview = new DataView(ds.Tables[0]);
                        dview.Sort = "cDepartmentCode";

                        int i = dview.Find(txtDepartmentCode.Text);

                        if (i < 0)   //comparing value
                        {
                            MessageBox.Show("No Recods Found");
                        }
                        else
                        {
                            cmgr.Position = i;//position textbox value in table
                 

                            drv = (DataRowView)cmgr.Current;    //storing values into textbox


                            dr["cDepartmentCode"] = txtDepartmentCode.Text;
                            dr["vDepartmentName"] = txtDepartmentName.Text;
                            dr["vDepartmentHead"] = txtDepartmentHead.Text;
                            dr["vLocation"] = txtLocation.Text;
                           

                            ds.Tables["Department"].Rows.Add(dr);
                           
                            adapter.Update(ds, "Department");
                          

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wrong Input");

                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connHR"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;


                    DataRow dr = ds.Tables["Department"].Rows.Find(txtDepartmentCode.Text);

                    cmgr = (CurrencyManager)GridDepartment.BindingContext[ds.Tables[0]];//Currencymgr class managing and binding objects
                    try
                    {
                        DataView dview = new DataView(ds.Tables[0]);
                        dview.Sort = "cDepartmentCode";

                        int i = dview.Find(txtDepartmentCode.Text);
                        if (i < 0)   //comparing value
                        {
                            MessageBox.Show("No Recods Found");
                        }
                        else
                        {
                            cmgr.Position = i;//position textbox value in table

                            drv = (DataRowView)cmgr.Current;    //storing values into textbox
                            txtDepartmentCode.Text = drv.Row[0].ToString();
                            txtDepartmentName.Text = drv.Row[1].ToString();
                            txtDepartmentHead.Text = drv.Row[2].ToString();
                            txtLocation.Text = drv.Row[3].ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Incorrect Input");
                        
                    }


                }
            }
        }
    }
}
