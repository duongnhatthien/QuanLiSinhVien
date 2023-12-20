using System;
using System.Collections.Generic;
using System.Drawing;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CInstuctor : CPerson
    {
        private List<CCourse> _teachCourses;
        public List<CCourse> TeachCourses { get { return _teachCourses; } set { _teachCourses = value; } }
        public CInstuctor(string id, string name, DateTime dob, string address, string email, string phone, Image picture, Gender gender, bool isAdmin, string password, List<CCourse> courses)
            :base(id,name,dob,address,email,phone,picture,gender, isAdmin,password,DateTime.Now)
        {
            _teachCourses = courses;
        }
        public CInstuctor() : base() {
            _teachCourses = new List<CCourse>();
        }
        public override TypeUser GetTypeUser()
        {
            return TypeUser.Instructor;
        }
    }
}
