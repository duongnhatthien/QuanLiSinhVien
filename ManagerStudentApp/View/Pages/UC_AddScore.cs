using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_AddScore : UserControl
    {
        private CHandleStudent _handleStudent;
        private CHandleCourse _handleCourse;
        private CHandleGrade _handleGrade;

        public UC_AddScore()
        {
            InitializeComponent();
            _handleStudent = new CHandleStudent();
            _handleCourse = new CHandleCourse();
            _handleGrade = new CHandleGrade();
        }
        private void ShowOnComboxBox()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _handleCourse.GetList();
            cbcCourse.DisplayMember = "Name";
            cbcCourse.ValueMember = "Id";
            cbcCourse.DataSource = bs;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtIdStudent.Text != null && cbcCourse.SelectedItem != null && txtMark.Text != null && txtDescription.Text != null)
            {
                CStudent student = new CStudent();
                student = _handleStudent.GetById(txtIdStudent.Text);
                if (student != null)
                {
                    double mark = 0;
                    if (Double.TryParse(txtMark.Text, out mark))
                    {
                        if (mark > 0 && mark < 10)
                        {
                            CCourse course = new CCourse();
                            course = _handleCourse.GetById(cbcCourse.SelectedValue.ToString());
                            CGrade grade = new CGrade(txtId.Text,student, mark, course, txtDescription.Text.ToString());
                            student.AddScore(grade);
                            if (_handleGrade.Add(grade))
                            {
                                MessageBox.Show("Add score successful", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ShowData();
                            }
                        }
                        else
                            MessageBox.Show("Score must be greater than 0 and less than 10", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Invalid score", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No matching students were found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be left blank", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void UC_AddScore_Load(object sender, EventArgs e)
        {
            txtId.Focus();
            ShowOnComboxBox();
            ShowData();
            if (CCurrentUser.User.GetTypeUser() == TypeUser.Student)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                return;
            }
        }
        void ShowData()
        {
           BindingSource bs = new BindingSource();
            bs.DataSource = _handleGrade.GetList();
            dgvDisplay.DataSource = bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
               string id = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();
                _handleGrade.Delete(id);
                ShowData();
            }
            else
            {
                MessageBox.Show("Delete failed classroom", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            clearTextBox();
        }
        private void clearTextBox()
        {
            txtId.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtIdStudent.Text = string.Empty;
            txtMark.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
