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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_Dashboard : UserControl
    {
        private CHandleStudent _handleStudent;
        private static int _numbericMale, _numbericFemale;
        private static bool flag = true;
        public UC_Dashboard()
        {
            InitializeComponent();
            _handleStudent = new CHandleStudent();
            dgvDisplay.AutoGenerateColumns = false;
            showDataOnDataGridView();
        }
        void getGender()
        {

            if(flag)
            {
                List<CStudent> lst = _handleStudent.GetList();
                foreach (CStudent student in lst)
                {
                    if (student.Gender == Gender.Male)
                    {
                        _numbericMale++;
                    }
                    else
                        _numbericFemale++;
                }
                flag = false;
            }
        }
        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            lblTotalStudent.Text = _handleStudent.GetList().Count.ToString();
            getGender();
            lblFemale.Text = _numbericFemale.ToString();
            lblMale.Text = _numbericMale.ToString();

        }
        void showDataOnDataGridView()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _handleStudent.GetList().OrderByDescending(s => s.AvergeScore);
            dgvDisplay.DataSource = bs;
        }
        
    }
}
