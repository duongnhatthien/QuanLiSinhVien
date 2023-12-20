using System;
using System.Collections.Generic;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CClassroom : CBaseClassroomCourse
    {
        private CInstuctor _instuctor;
        public CInstuctor Instuctor { get => _instuctor; set => _instuctor = value; }
        public CClassroom() : base(){ 
            _instuctor = new CInstuctor();
        }
        public CClassroom(string id, string name, List<CStudent> students, CInstuctor cInstuctor) : base(students, id, name) {
            _instuctor = cInstuctor;
        }

        public override bool AddStudent(CStudent nStudent)
        {
            if(nStudent == null)
            {
                return false;
            }
            else
            {
                _students.Add(nStudent);
                nStudent.Classroom = this;
                return true;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
