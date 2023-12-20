using ManagerStudentApp.Controller;
using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_ListStudent : UserControl
    {
        private CHandleStudent _handleStudent;
        private CHandleClassroom _handleClassroom;
        public UC_ListStudent()
        {
            InitializeComponent();
        }

        private void UC_ListStudent_Load(object sender, EventArgs e)
        {
            _handleStudent = new CHandleStudent();
            _handleClassroom = new CHandleClassroom();
            dgvDisplay.AutoGenerateColumns = false;
            ShowData();
            ShowDataOnCombobox();
            if (CCurrentUser.User.GetTypeUser() == TypeUser.Student)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                return;
            }
        } 

        private void ShowData()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _handleStudent.GetList();
            dgvDisplay.DataSource = bs;
        }
        private void ShowDataOnCombobox()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _handleClassroom.GetList();
            cbComboBox.DataSource = bs;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                string id = dgvDisplay.SelectedRows[0].Cells["ColId"].Value.ToString();
                if (_handleStudent.Delete(id))
                {
                    MessageBox.Show("Delete succeccful instructor", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ShowData();
                    return;
                }
                else
                {
                    MessageBox.Show("Delete failed instructor", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                CStudent student = new CStudent();
                string id = dgvDisplay.SelectedRows[0].Cells["ColId"].Value.ToString();
                student = _handleStudent.GetById(id);
                if (student != null)
                {
                    frmEdit frm = new frmEdit(student);
                    frm.FormClosed += (s, ev) =>
                    {
                        ShowData();
                    };
                    frm.ShowDialog();
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvDisplay.Rows)
            {
                if ((r.Cells["ColName"].Value).ToString().ToUpper().Contains(txtFilter.Text.ToUpper())
                    || (r.Cells["ColId"].Value).ToString().ToUpper().Contains(txtFilter.Text.ToUpper()))
                {
                    dgvDisplay.Rows[r.Index].Visible = true;
                }
                else
                {
                    dgvDisplay.CurrentCell = null;
                    dgvDisplay.Rows[r.Index].Visible = false;
                }
            }
        }

        private void cbComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvDisplay.Rows)
            {
                if ((r.Cells["ColClassroom"].Value).ToString().ToUpper().Contains(cbComboBox.SelectedValue.ToString().ToUpper()))
                {
                    dgvDisplay.Rows[r.Index].Visible = true;
                }
                else
                {
                    dgvDisplay.CurrentCell = null;
                    dgvDisplay.Rows[r.Index].Visible = false;
                }
            }
        }

        private void UC_ListStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.F)
            {
                txtFilter.Focus();
            }
        }
    }
}
