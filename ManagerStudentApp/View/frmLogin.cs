using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using ManagerStudentApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagerStudentApp
{
    public partial class frmLogin : Form
    {
        private CHandleStudent _handleStudent;
        private CHandleInstructor _handleInstructor;
        public frmLogin()
        {
            InitializeComponent();
            CSingleton.LoadFile();
            _handleStudent = new CHandleStudent();
            _handleInstructor = new CHandleInstructor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntClosedEye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnEye.Visible = true;
            bntClosedEye.Visible = false;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            bntClosedEye.Visible = true;
            btnEye.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CAdmin admin = new CAdmin("admin", "123456");
            if(txtUsername.Text == "admin" && txtPassword.Text =="12345")
            {
                CCurrentUser.User = admin;
                ShowFrmMain();
                return;
            }
            List<CStudent> students = _handleStudent.GetList();
            List<CInstuctor> instuctors = _handleInstructor.GetList();
            foreach (var item in students)
            {
                if (string.Compare(txtUsername.Text, item.Email) == 0 && string.Compare(txtPassword.Text, item.Password) == 0)
                {
                    CCurrentUser.User = item;
                    ShowFrmMain();
                    return;
                }
            }
            foreach (var item in instuctors)
            {
                if (string.Compare(txtUsername.Text, item.Email) == 0 && string.Compare(txtPassword.Text, item.Password) == 0)
                {
                    CCurrentUser.User = item;
                    ShowFrmMain();
                    return;
                }
            }
            lblError.Text = "Username or password incorrect";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtUsername.Text = "tri@gmail.com";
            txtPassword.Text = "11112023";
        }
        private void ShowFrmMain()
        {
            DialogResult = DialogResult.OK;
        }
    }
}
