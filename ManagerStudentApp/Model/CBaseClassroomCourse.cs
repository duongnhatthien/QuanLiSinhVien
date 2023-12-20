using System;
using System.Collections.Generic;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CBaseClassroomCourse : CCommon
    {
        protected List<CStudent> _students;
        public CBaseClassroomCourse(List<CStudent> list, string id, string name):base(id,name,new DateTime(), DateTime.Now) {
            _students = list;
        }
        public CBaseClassroomCourse() :base() { 
           _students = new List<CStudent>();
        }
        
        public List<CStudent> Students { get => _students; set => _students = value; }
        public virtual bool AddStudent(CStudent nStudent)
        {
            return false;
        }
        public List<CStudent> getListStudent()
        {
            return _students;
        }
    }
}
