using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_CreateClassroom : UserControl
    {
        private CHandleInstructor _handleInstuctor;
        private CHandleClassroom _handleClassroom;
        public UC_CreateClassroom()
        {
            InitializeComponent();
        }

        private void UC_CreateClassroom_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            _handleInstuctor = new CHandleInstructor();
            _handleClassroom = new CHandleClassroom();
            dgvDisplay.AutoGenerateColumns = false;
            ShowData();
            if (CCurrentUser.User.GetTypeUser() == TypeUser.Student)
            {
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(txtId.Text != "" && txtName.Text != "" && txtIdInstuctor.Text != "")
            {
               if(Regex.IsMatch(txtId.Text,@"CL\d{1,}$") && Regex.IsMatch(txtName.Text, @"D\d{2}_TH\d{2}$"))
                {
                    CInstuctor cInstuctor = _handleInstuctor.GetById(txtIdInstuctor.Text);
                    if (cInstuctor == null)
                    {
                        MessageBox.Show("Not found id instuctor", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CClassroom classroom = new CClassroom(txtId.Text, txtName.Text, new List<CStudent>(), cInstuctor);
                        if (_handleClassroom.Add(classroom))
                            ShowData();
                        else
                            MessageBox.Show("The classroom code is duplicated", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    clearTextBox();
                }
               else
                {
                    MessageBox.Show("You need to enter the correct format in the Id and Classname textboxs", "Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
           else
            {
                MessageBox.Show("You need to completely fill out all information fields", "Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void ShowData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _handleClassroom.GetList();
            dgvDisplay.DataSource = bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvDisplay.SelectedRows.Count > 0)
            {
                string id = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();
                _handleClassroom.Delete(id);
                ShowData();
            }
            else
            {
                MessageBox.Show("Delete failed classroom", "Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            clearTextBox();
        }
        private void clearTextBox()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtIdInstuctor.Text = string.Empty;
        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDisplay.SelectedRows.Count > 0)
            {
                string id = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();
                CClassroom cl = _handleClassroom.GetById(id);
                if(cl != null)
                {
                    txtId.Text = cl.Id;
                    txtName.Text = cl.Name;
                    txtIdInstuctor.Text = cl.Instuctor.Id;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dgvDisplay.SelectedRows.Count > 0)
            {
                string id = txtId.Text;
                CInstuctor cInstuctor = _handleInstuctor.GetById(txtIdInstuctor.Text);
                CClassroom classroom = new CClassroom(txtId.Text, txtName.Text, new List<CStudent>(), cInstuctor);
                _handleClassroom.Update(id,classroom);
                ShowData();
            }
        }
    }
}
