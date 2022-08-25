using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project__of_ado_dot_net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpatients pa = new Frmpatients();
            pa.MdiParent = this;
            pa.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdoctor doc = new Frmdoctor();
            doc.MdiParent = this;
            doc.Show();
        }

        private void patientTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpttype tr = new Frmpttype();
            tr.MdiParent = this;
            tr.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reportViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReport re = new FrmReport();
            
            re.Show();
        }
    }
}
