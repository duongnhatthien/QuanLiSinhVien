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

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_ListInstructor : UserControl
    {
        private CHandleInstructor _handleInstructor;
        private CHandleClassroom _handleClassroom;
        public UC_ListInstructor()
        {
            InitializeComponent();
        }

        private void UC_ListInstructor_Load(object sender, EventArgs e)
        {
            _handleInstructor = new CHandleInstructor();
            dgvDisplay.AutoGenerateColumns = false;
            ShowData();
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
            bs.DataSource = _handleInstructor.GetList();
            dgvDisplay.DataSource = bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count > 0)
            {
                string id = dgvDisplay.SelectedRows[0].Cells["ColId"].Value.ToString();
                if (_handleInstructor.Delete(id))
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
                CInstuctor instructor = new CInstuctor();
                string id = dgvDisplay.SelectedRows[0].Cells["ColId"].Value.ToString();
                instructor = _handleInstructor.GetById(id);
                if (instructor != null)
                {
                    frmEditInstuctor frm = new frmEditInstuctor(instructor);
                    frm.FormClosed += (s, ev) =>
                    {
                        ShowData();
                    };
                    frm.ShowDialog();
                }
            }
        }

        private void UC_ListInstructor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.F)
                txtFilter.Focus();
        }
    }
}
