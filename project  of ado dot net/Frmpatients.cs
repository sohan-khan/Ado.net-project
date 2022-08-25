using System;
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

namespace project__of_ado_dot_net
{
    public partial class Frmpatients : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H9A00LE;Initial Catalog=hmdbs;Integrated Security=True");
        public Frmpatients()
        {
            InitializeComponent();
        }

        private void lblpatients_Click(object sender, EventArgs e)
        {

        }

        
        private void Btnupload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "select Image";
            fileOpen.Filter = "Image File(*.png;*.jpg; *.jpeg*.bmp;*.gif)|*.png;*.jpg; *.jpeg*.bmp;*.gif|All fiels(*.*)|*.*";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileOpen.FileName);
            }
            fileOpen.Dispose();
        }

        private byte[] savephoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Allclear()
        {
            txtId.Text = "";
            txtname.Text = "";
            dateTimePicker1.Text = "";
            pictureBox1.Image = null;
            comboBox1.SelectedIndex = -1;
        }
        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtname.Text == "" || dateTimePicker1.Text == "" || pictureBox1.Image == null || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string qry = "Insert INTO patients(pid,pname,Appoinmentdate,category,picture)values(@i,@n,@d,@c,@img)";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@i", txtId.Text);
                    cmd.Parameters.AddWithValue("@n", txtname.Text);
                    cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@c", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@img", savephoto());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("data inserted successfully");
                    Allclear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Loadcombo()
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  Category,PtId from PatientType", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "PtId";
            con.Close();


        }

        private void Frmpatients_Load(object sender, EventArgs e)
        {
            Loadcombo();
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            Allclear();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string qry = "update patients set pid=@i,pname=@n,Appoinmentdate=@d,category=@c,picture=@img where pid='" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@n", txtname.Text);
                cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@c", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@img", savephoto());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("data updated successfully");
                Allclear();
                displaydata();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string qry = " delete from patients where pid='" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("data deleted successfully");
                Allclear();
                displaydata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void displaydata()
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patients";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from patients where pid='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    textBox1.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private Image Getphoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            pictureBox1.Image = Getphoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);

        }
    }
}
