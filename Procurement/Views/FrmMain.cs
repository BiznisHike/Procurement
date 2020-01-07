using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void lnkProjects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBOM frmBOM = new FrmBOM();
            frmBOM.Show();
        }

        private void lnkEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEmployee frmEmp = new FrmEmployee();
            frmEmp.Show();
        }
    }
}
