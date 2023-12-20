using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CPerson : CCommon
    {
        private DateTime _dob;
        private string _address;
        private string _email;
        private string _phone;
        private Image _picture;
        private Gender _gender;
        private bool _isAdmin;
        private string _password;

        public DateTime Dob { get => _dob; set => _dob = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public Image Picture { get => _picture; set => _picture = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
        public string Password { get => _password; set => _password = value; }

        public CPerson(string id, string name, DateTime dob, string address, string email, string phone, Image picture, Gender gender, bool isAdmin, string password, DateTime create)
            : base(id,name,new DateTime(),create)
        {
            Dob = dob;
            Address = address;
            Email = email;
            Phone = phone;
            Picture = picture;
            Gender = gender;
            IsAdmin = isAdmin;
            Create = DateTime.Now;
            Password = password;
        }

        public CPerson() : base() {

            Dob = new DateTime();
            Address = "";
            Email = "";
            Phone = "";
            Picture = Image.FromFile("K:\\C#\\Đồ Án Tin Học\\ManagerStudentApp\\ManagerStudentApp\\Resources\\icons8-user-100.png");
            Gender = new Gender();
            IsAdmin = false;
            Create = DateTime.Now;
            Password = Dob.ToString("ddMMyyyy");
        }
        virtual public TypeUser GetTypeUser()
        {
            return TypeUser.Student;
        }
    }
    public enum Gender { Male, Female};
    public enum TypeUser { Student, Instructor, Admin}
}
