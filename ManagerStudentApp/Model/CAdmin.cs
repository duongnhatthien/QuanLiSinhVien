using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Model
{
    internal class CAdmin : CPerson
    {
        public CAdmin(string username, string password) : base("","Admin",DateTime.Now,"",username,"", Image.FromFile("K:\\C#\\Đồ Án Tin Học\\ManagerStudentApp\\ManagerStudentApp\\Resources\\icons8-user-100.png"),Gender.Male,true,password,DateTime.Now) { 
            
        }
        public override TypeUser GetTypeUser()
        {
            return TypeUser.Admin;
        }
    }
}
