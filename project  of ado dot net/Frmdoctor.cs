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
    public partial class Frmdoctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H9A00LE;Initial Catalog=hmdbs;Integrated Security=True");
        public Frmdoctor()
        {
            
            InitializeComponent();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmdoctor_Load(object sender, EventArgs e)
        {
            Loadcombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Loadcombo()
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT deptname,deptId from departments", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "deptname";
            comboBox1.ValueMember = "deptId";
            con.Close();


        }

        private void clear()
        {
            txtfee.Text = null;
            txtId.Text = null;
            txtname.Text = null;
            comboBox1.SelectedIndex = -1;
        }
        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtname.Text == "" || txtfee.Text==""|| comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string qry = "Insert INTO doctors(doctorId,doctorname,deptname,doctorfee)values(@i,@n,@d,@f)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@i", txtId.Text);
                    cmd.Parameters.AddWithValue("@n", txtname.Text);
                    cmd.Parameters.AddWithValue("@d", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@f", txtfee.Text);
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

        private void Btnreset_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
