using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.View
{
    public partial class frmEdit : Form
    {
        private CStudent _student;
        private CHandleClassroom _handleClassroom;
        private CHandleStudent _handleStudent;
        public frmEdit(CStudent student)
        {
            InitializeComponent();
            _student = student;

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            _handleClassroom = new CHandleClassroom();
            _handleStudent = new CHandleStudent();

            ShowDataOnControl();
            ShowDataOnCommboBox();

            foreach (var item in cbClassroom.Items)
            {
                if (item.ToString().Contains(_student.Classroom.Id.ToString()))
                {
                    cbClassroom.SelectedItem = item;
                    break;
                }
            }


        }

        private void ShowDataOnControl()
        {
            txtId.Text = _student.Id;
            txtName.Text = _student.Name;
            txtAddress.Text = _student.Address;
            txtEmail.Text = _student.Email;
            txtPhone.Text = _student.Phone;
            dpkBirthdate.Value = _student.Dob;
            cpbPicture.Image = _student.Picture;
           
            if (_student.Gender == Gender.Male)
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
            string[] parts = cbClassroom.Text.Split('-');
            string id = parts[0].Trim();
            CClassroom cl = _handleClassroom.GetById(id);
            CStudent student = new CStudent(txtId.Text, txtName.Text, dpkBirthdate.Value, txtAddress.Text, txtEmail.Text, txtPhone.Text, cpbPicture.Image, getRadioButton(), false, dpkBirthdate.Value.ToString(), null, cl);
            cl.AddStudent(student);
            if (_handleStudent.Update(student.Id, student))
            {
                var result = MessageBox.Show("Save successful student", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                var result = MessageBox.Show("Save Failed student", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            List<string> lstNameClass = new List<string>();
            foreach (var item in list)
            {
                lstNameClass.Add(item.Id + " - " + item.Name);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = lstNameClass;
            cbClassroom.DataSource = bs;
        }
    }
}
