using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CGrade
    {
        private string _id;
        private CStudent  _student;
        private double _marks;
        private CCourse _course;
        private string _description;
        public CGrade() : this("",new CStudent(),0,new CCourse(),"") { }

        public CGrade(string id,CStudent student, double marks, CCourse course, string description)
        {
            _id = id;
            Student = student;
            Marks = marks;
            Course = course;
            _description = description;
        }

        public string Id { get => _id; set => _id = value; }
        public string Description { get { return _description; } set { _description = value; } }
        public CStudent Student { get => _student; set => _student = value; }
        public double Marks { get => _marks; set => _marks = value; }
        public CCourse Course { get => _course; set => _course = value; }
        public string Active {
            get
            {
                if (_marks >= 4.5)
                    return "Pass";
                return "Fail";
            }
        }
    }
}
