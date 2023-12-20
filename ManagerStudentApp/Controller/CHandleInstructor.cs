using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagerStudentApp.Controller
{
    internal class CHandleInstructor : IHandle<CInstuctor>
    {
        private static LinkedList<CInstuctor> _instructors = new LinkedList<CInstuctor>();
        public CHandleInstructor()
        {
            CSingleton sigleton = CSingleton.Instance();
            _instructors = sigleton.getInstuctorList();
        }
        public bool Add(CInstuctor item)
        {

            if (_instructors == null)
                return false;
            var result = GetById(item.Id);
            if (result != null)
            {
                return false;
            }
            else
            {
                _instructors.AddLast(item);
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
                _instructors.Remove(result);
                return true;
            }
        }

        public List<CInstuctor> GetList()
        {
            return _instructors.ToList();
        }

        public CInstuctor GetById(string id)
        {
            foreach (var ins in _instructors)
            {
                if (ins.Id == id)
                    return ins;
            }
            return null;
        }
        public bool Update(string id, CInstuctor value)
        {
            var instuctor = GetById(id);
            if (instuctor != null)
            {
                instuctor.Update = DateTime.Now;
                instuctor.Name = value.Name;
                instuctor.Dob = value.Dob;
                instuctor.Address = value.Address;
                instuctor.Email = value.Email;
                instuctor.Phone = value.Phone;
                instuctor.Picture = value.Picture;
                instuctor.Gender = value.Gender;
                instuctor.IsAdmin = value.IsAdmin;
                instuctor.Password = value.Password;
                instuctor.TeachCourses = value.TeachCourses;
                instuctor.Update = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
