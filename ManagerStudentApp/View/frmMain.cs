using Guna.UI2.WinForms;
using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using ManagerStudentApp.View.Pages;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagerStudentApp.View
{
    public partial class frmMain : Form
    {
        CHandleInstructor CHandleInstructor;
        CHandleStudent CHandleStudent;
        CHandleClassroom CHandleClassroom;

        public frmMain()
        {
            InitializeComponent();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
           UC_Dashboard uc = new UC_Dashboard();
            AddUserControl( uc );
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            UC_CreateStudent uc = new UC_CreateStudent();
            AddUserControl( uc );
        }
        public DialogResult ShowMessageBox(string text, string caption, MessageDialogButtons buttons, MessageDialogIcon icon)
        {
            guna2MessageDialog1.Text = text;
            guna2MessageDialog1.Caption = caption;
            guna2MessageDialog1.Icon = icon;
            guna2MessageDialog1.Buttons = buttons;
            return guna2MessageDialog1.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = ShowMessageBox("Do you sure you want to exit ?", "Exit", MessageDialogButtons.OKCancel, MessageDialogIcon.Question);
            if (result == DialogResult.Yes)
            {
               Application.Exit();
            }
            return;
        }

        private void btnListStudent_Click(object sender, EventArgs e)
        {
            UC_ListStudent uc = new UC_ListStudent();
            AddUserControl(uc );
        }

        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CHandleStudent = new CHandleStudent();
            CHandleInstructor = new CHandleInstructor();
            CHandleClassroom = new CHandleClassroom();
            UC_Dashboard uc = new UC_Dashboard();
            AddUserControl(uc);
            ShowCurrentUser();
            roleUser();

        }
        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            UC_CreateInstructor uc = new UC_CreateInstructor();
            AddUserControl(uc);
        }

        private void btnListInstructor_Click(object sender, EventArgs e)
        {
            UC_ListInstructor uc = new UC_ListInstructor();
            AddUserControl(uc);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSingleton.SaveFile();
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            UC_CreateClassroom uc = new UC_CreateClassroom();
            AddUserControl(uc);
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            UC_CreateCourse uc = new UC_CreateCourse();
            AddUserControl(uc);
        }
        private void ShowCurrentUser()
        {
                string[] displayName = CCurrentUser.User.Name.Split(' ');
                cpbAvatar.Image = CCurrentUser.User.Picture;
                lblDisplayName.Text = displayName[displayName.Length - 1];
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            UC_AddScore uc = new UC_AddScore();
            AddUserControl(uc);
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            UC_ViewScore uc = new UC_ViewScore();
            AddUserControl(uc);
        }
        private void roleUser()
        {
            if(CCurrentUser.User.GetTypeUser() == TypeUser.Student)
            {
                btnAddInstructor.Enabled = false;
                btnAddScore.Enabled = false;
                btnAddStudent.Enabled = false;
                btnClassroom.Enabled = false;
                btnCreateCourse.Enabled = false;
            }
            else if(CCurrentUser.User.GetTypeUser() == TypeUser.Instructor)
            {
                btnAddInstructor.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
