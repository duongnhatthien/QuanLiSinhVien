using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Windows.Forms;

namespace ManagerStudentApp.View
{
    public partial class frmEditInstuctor : Form
    {
        private CInstuctor _instuctor;
        public frmEditInstuctor(CInstuctor instuctor)
        {
            InitializeComponent();
            _instuctor = instuctor;
        }

        private void frmEditInstuctor_Load(object sender, EventArgs e)
        {
            ShowDataOnControl();
        }
        private void ShowDataOnControl()
        {
            txtId.Text = _instuctor.Id;
            txtName.Text = _instuctor.Name;
            txtAddress.Text = _instuctor.Address;
            txtEmail.Text = _instuctor.Email;
            txtPhone.Text = _instuctor.Phone;
            dpkBirthdate.Value = _instuctor.Dob;
            cpbPicture.Image = _instuctor.Picture;

            if (_instuctor.Gender == Gender.Male)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
        }
        private Gender getRadioButton()
        {
            if (rdbMale.Checked)
                return Gender.Male;
            else
                return Gender.Female;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CHandleInstructor _handle = new CHandleInstructor();
            CInstuctor instuctor = new CInstuctor(txtId.Text, txtName.Text, dpkBirthdate.Value, txtAddress.Text, txtEmail.Text, txtPhone.Text, cpbPicture.Image, getRadioButton(), false, dpkBirthdate.Value.ToString(), null);
            if (_handle.Update(instuctor.Id, instuctor))
            {
                var result = MessageBox.Show("Save successful student", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                var result = MessageBox.Show("Save Failed student", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
