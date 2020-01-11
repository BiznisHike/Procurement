using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Procurement.Classes;
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
            this.Visible = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (LoginInfo.LoginEmployee.EmployeeTypeCode  == 2)
            {
                pnlEmployees.Visible = false;
            
            }
        }

        #region "Click On Panel"
        

        private void pnlProjects_MouseEnter(object sender, EventArgs e)
        {
            pnlProjects.BackColor = Color.WhiteSmoke;
        }

        private void pnlProjects_MouseLeave(object sender, EventArgs e)
        {
            pnlProjects.BackColor = Color.White;
        }

        private void pnlEmployees_MouseLeave(object sender, EventArgs e)
        {
            pnlEmployees.BackColor = Color.White;
        }

        private void pnlEmployees_MouseEnter(object sender, EventArgs e)
        {
            pnlEmployees.BackColor = Color.WhiteSmoke;
        }

        private void pnlEmployees_MouseClick(object sender, MouseEventArgs e) 
        {
            FrmEmployee_Show();
        }
        private void pnlProjects_MouseClick(object sender, MouseEventArgs e)
        {
            FrmBOM_Show();
        }
        private void FrmBOM_Show()
        {
            FrmBOM frmBOM = new FrmBOM();
            frmBOM.Show();

        }
        private void FrmEmployee_Show()
        {
            FrmEmployee frmEmp = new FrmEmployee();
            frmEmp.Show();
        }

        private void lnkProjects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBOM_Show();
        }

        private void lnkEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEmployee_Show();
        }

        private void lblProject_Click(object sender, EventArgs e)
        {
            FrmBOM_Show();
        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee_Show();
        }

        private void lblProjectDesc_Click(object sender, EventArgs e)
        {
            FrmBOM_Show();
        }

        private void lblEmployeeDesc_Click(object sender, EventArgs e)
        {
            FrmEmployee_Show();
        }

        #endregion "Click On Panel"
    }
}
