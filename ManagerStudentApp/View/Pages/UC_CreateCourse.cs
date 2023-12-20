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
    public partial class UC_CreateCourse : UserControl
    {
        private CHandleCourse _handleCourse;
        public UC_CreateCourse()
        {
            InitializeComponent();
            dgvDisplay.AutoGenerateColumns = false;
            _handleCourse = new CHandleCourse();
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeSpan startTime = new TimeSpan();
            TimeSpan endTime = new TimeSpan();

            if (txtId.Text != "" && txtDes.Text != "" && txtName.Text != "" && txtStartTime.Text != ""
                && txtEndTime.Text != "" && !DateTime.Equals(dpkDate.Value, DateTime.Now))
            {
                if (TimeSpan.TryParse(txtStartTime.Text, out startTime) == false || TimeSpan.TryParse(txtEndTime.Text, out endTime) == false)
                {
                    MessageBox.Show("Please enter the start and end times in the format hours:minutes", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                CCourse course = new CCourse(txtId.Text, txtName.Text, null, dpkDate.Value, startTime, endTime, txtDes.Text);
                if (_handleCourse.Add(course))
                {
                    ShowData();
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be left blank", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void ShowData()
        {
           BindingSource bs = new BindingSource();
            bs.DataSource = _handleCourse.GetList();
            dgvDisplay.DataSource = bs;
        }

        private void UC_CreateCourse_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }
    }
}
