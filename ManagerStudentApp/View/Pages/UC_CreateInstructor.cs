using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_CreateInstructor : UserControl
    {
        CHandleInstructor _handleInstructor;
        public UC_CreateInstructor()
        {
            InitializeComponent();
        }

        private void UC_CreateInstructor_Load(object sender, EventArgs e)
        {
            _handleInstructor = new CHandleInstructor();
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

           if(txtId.Text != "" && txtName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtPhone.Text != "" 
                && (rdbFemale.Checked == true || rdbMale.Checked == true) && txtAddress.Text != "")
            {
              if(CUserInputValidator.IsEmailValid(txtEmail.Text) && CUserInputValidator.IsPhoneNumberValid(txtPhone.Text))
              {
                    CInstuctor student = new CInstuctor(txtId.Text, txtName.Text, dpkBirthdate.Value, txtAddress.Text, txtEmail.Text, txtPhone.Text, cpbPicture.Image, getRadioButton(), false, dpkBirthdate.Value.ToString("ddMMyyyy"), null);
                    if (_handleInstructor.Add(student))
                    {
                        MessageBox.Show("create successful instructor", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
    }
}
