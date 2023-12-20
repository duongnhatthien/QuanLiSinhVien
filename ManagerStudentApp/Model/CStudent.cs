using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CStudent : CPerson
    {
        private List<CCourse> _learnCourses;
        private CClassroom _classroom;
        private List<CGrade> _scores;

        public List<CCourse> LearnCourses { get { return _learnCourses; } set { _learnCourses = value; } }  
        public CClassroom Classroom { get => _classroom; set => _classroom = value; }
        public List<CGrade> Scores { get => _scores; set => _scores = value; }
        public CStudent(string id, string name, DateTime dob, string address, string email, string phone, Image picture, Gender gender, bool isAdmin, string password, List<CCourse> courses, CClassroom classroom)
            : base(id,name,dob,address,email,phone, picture, gender,isAdmin, password, DateTime.Now)
        {
            _learnCourses = courses;
            _classroom = classroom;
            _scores = new List<CGrade>();
        }
        public CStudent() : base() {
            _learnCourses = new List<CCourse>();
            _scores = new List<CGrade>();
        }
        public double AvergeScore
        {
            get
            {
                if (_scores == null)
                {
                    _scores = new List<CGrade>();
                    return 0; // hoặc giá trị mặc định khác tùy thuộc vào yêu cầu của bạn
                }

                double avgScore = 0;
                foreach (var item in _scores)
                {
                    avgScore += item.Marks;
                }
                return avgScore / Scores.Count * 1.0;
            }
        }

        public void RegisterForCourse(CCourse c)
        {
            _learnCourses.Add(c);
            c.AddStudent(this);
        }
        public void AddScore(CGrade score)
        {
            if(Scores == null)
                Scores = new List<CGrade>();
            Scores.Add(score);
        }
        public List<CGrade> ViewGrades()
        {
            return _scores;
        }
        public override string ToString()
        {
            return Name;
        }
        public override TypeUser GetTypeUser()
        {
            return TypeUser.Student;
        }
    }
}
