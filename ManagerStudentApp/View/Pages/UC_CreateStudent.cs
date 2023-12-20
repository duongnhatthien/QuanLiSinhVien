using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_CreateStudent : UserControl
    {
        private CHandleStudent _handleStudent;
        private CHandleClassroom _handleClassroom;


        public UC_CreateStudent()
        {
            InitializeComponent();
        }

        private void UC_CreateStudent_Load(object sender, EventArgs e)
        {
            _handleStudent = new CHandleStudent();
            _handleClassroom = new CHandleClassroom();
            ShowDataOnCommboBox();
            txtId.Focus();
        }
        private Gender getRadioButton()
        {
            if (rdbMale.Checked)
                return Gender.Male;
            else
                return Gender.Female;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "" && txtName.Text != "" && !DateTime.Equals(dpkBirthdate.Value, DateTime.Now) && txtEmail.Text != ""
                && txtPhone.Text != "" && (rdbFemale.Checked == true || rdbMale.Checked == true) && txtAddress.Text != "" )
            {
                if (CUserInputValidator.IsEmailValid(txtEmail.Text) && CUserInputValidator.IsPhoneNumberValid(txtPhone.Text))
                {
                    string id = cbClassroom.SelectedValue.ToString();
                    CClassroom cl = _handleClassroom.GetById(id);
                    CStudent student = new CStudent(txtId.Text, txtName.Text, dpkBirthdate.Value, txtAddress.Text, txtEmail.Text, txtPhone.Text, cpbPicture.Image, getRadioButton(), false, dpkBirthdate.Value.ToString("ddMMyyyy"), null, cl);
                    cl.AddStudent(student);
                    if (_handleStudent.Add(student))
                    {
                        MessageBox.Show("create successful students", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Id duplicated", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Email and phone number must be entered in the correct format", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields in the form cannot be left blank", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog sf = new OpenFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(sf.FileName);
                cpbPicture.Image = img;
            }
        }
        private void ShowDataOnCommboBox()
        {
            var list = _handleClassroom.GetList();
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            cbClassroom.DisplayMember = "Name";
            cbClassroom.ValueMember = "Id";
            cbClassroom.DataSource = bs;
        }
    }
}
