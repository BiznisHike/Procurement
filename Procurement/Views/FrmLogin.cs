using Procurement.Classes;
using Procurement.Controllers;
using Procurement.Views;
using Repository.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement
{
    public partial class FrmLogin : Form
    {
        EmployeeController _ec;
        List<Employee> _LstEmployees;
        public FrmLogin()
        {
            InitializeComponent();


        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmMain"].Close();
            //this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            //base.OnFormClosed(e);
            //Application.Exit();

            //Application.OpenForms["FrmMain"].Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            _ec = new EmployeeController();
            _LstEmployees = _ec.GetModels();

            Employee employee = _LstEmployees.Where(x => x.EmployeeName == txtLogin.Text).FirstOrDefault();
            if (employee != null)
            {
                if (employee.Password == txtPwd.Text)
                {
                    //FrmMain frm = new FrmMain();
                    //frm.Show();
                    //this.Hide();
                    this.Close();
                    Application.OpenForms["FrmMain"].Visible = true;
                    //Application.Run(new FrmMain());
                    LoginInfo.LoginEmployee = employee;
                }
                else
                {
                    lblMsg.Text = "Password is invalid";
                }

            }
            else
            {
                lblMsg.Text = "Username is invalid";
            }


        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
