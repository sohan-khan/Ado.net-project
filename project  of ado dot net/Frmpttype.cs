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

namespace project__of_ado_dot_net
{
    public partial class Frmpttype : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H9A00LE;Initial Catalog=hmdbs;Integrated Security=True");
        public Frmpttype()
        {
            InitializeComponent();
        }
        private void AllClear()
        {
            txtctgId.Text = "";
            txtcategory.Text = "";
        }
        private void BtnctgSave_Click_1(object sender, EventArgs e)
        {
            if (txtctgId.Text == "" || txtcategory.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string qry = "Insert INTO PatientType(PtId,Category)values(@i,@c)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@i", txtctgId.Text);
                    cmd.Parameters.AddWithValue("@c", txtcategory.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("data inserted successfully");
                    AllClear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clear()
        {
            txtdeptId.Text = "";
            txtDept.Text = "";
        }
        private void BtndeptSave_Click(object sender, EventArgs e)
        {
            if (txtdeptId.Text == "" || txtDept.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string qry = "Insert INTO departments(deptId,deptname)values(@i,@d)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@i", txtdeptId.Text);
                    cmd.Parameters.AddWithValue("@d", txtDept.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("data inserted successfully");
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}
