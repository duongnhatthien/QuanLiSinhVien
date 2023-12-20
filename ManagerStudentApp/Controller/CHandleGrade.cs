using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Controller
{
    internal class CHandleGrade : IHandle<CGrade>
    {
        private static LinkedList<CGrade> _grades = new LinkedList<CGrade>();
        private CHandleStudent _handleStudent;
        public CHandleGrade()
        {
            CSingleton sigleton = CSingleton.Instance();
            _grades = sigleton.getGradeList();
            _handleStudent = new CHandleStudent();
        }
        public bool Add(CGrade item)
        {
            if (_grades == null)
                return false;
            var result = GetById(item.Id);
            if (result != null)
            {
                return false;
            }
            else
            {
                _grades.AddLast(item);
                return true;
            }
        }

        public bool Delete(string id)
        {
            var result = GetById(id);
            if (result == null)
                return false;
            else
            {
                _grades.Remove(result);
                var students = _handleStudent.GetList();
                foreach(var item in students)
                {
                    if(item.Id == result.Student.Id)
                    {
                        item.Scores.Remove(result);
                    }
                }
                return true;
            }
        }

        public List<CGrade> GetList()
        {
            return _grades.ToList();
        }

        public CGrade GetById(string id)
        {
            foreach (var grade in _grades)
            {
                if (grade.Id == id)
                    return grade;
            }
            return null;
        }
        public bool Update(string id, CGrade value)
        {
            var grade = GetById(id);
            if (grade != null)
            {
                grade.Marks = value.Marks;
                grade.Student = value.Student;
                grade.Course = value.Course;
                grade.Description = value.Description;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
