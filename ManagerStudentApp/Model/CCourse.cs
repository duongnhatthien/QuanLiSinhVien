using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CCourse : CBaseClassroomCourse
    {
        private TimeSpan _startTime;
        private TimeSpan _endTime;
        private DateTime _date;
        private string _description;

        public string Description { get => _description; set => _description = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public TimeSpan StartTime { get => _startTime; set => _startTime = value; } 
        public TimeSpan EndTime { get => _endTime; set => _endTime = value; }
       
        public CCourse(string id, string name,List<CStudent> erolledStudents, DateTime date, TimeSpan startTime, TimeSpan endTime, string description) : base(erolledStudents,id,name)
        {
            _date = date;
            _startTime = startTime;
            _endTime = endTime;
            _description = description;
        }
        public CCourse() : base(){

            _date = DateTime.Now;
            _startTime = new TimeSpan();
            _endTime = new TimeSpan();
            _description = "";
        }
      

        public override bool AddStudent(CStudent nStudent)
        {
            if (nStudent == null)
                return false;
            else
            {
                _students.Add(nStudent);
                nStudent.RegisterForCourse(this);
                return true;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
