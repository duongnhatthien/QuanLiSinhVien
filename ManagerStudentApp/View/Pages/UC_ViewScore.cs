using ManagerStudentApp.Model;
using System.Windows.Forms;

namespace ManagerStudentApp.View.Pages
{
    public partial class UC_ViewScore : UserControl
    {
        public UC_ViewScore()
        {
            InitializeComponent();
            dgvDisplay.AutoGenerateColumns = false;
            ShowData();
        }
        void ShowData()
        {
            BindingSource bs = new BindingSource();
            if(CCurrentUser.User.GetTypeUser() == TypeUser.Student) {
                CStudent student = new CStudent();
                student = CCurrentUser.User as CStudent;
                bs.DataSource = student.Scores;
            }
            dgvDisplay.DataSource = bs;
        }

    }
}
