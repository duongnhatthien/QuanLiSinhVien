using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.Controller
{
    internal class CHandleStudent : IHandle<CStudent>
    {
        private static LinkedList<CStudent> _students = new LinkedList<CStudent>();
        public CHandleStudent()
        {
            CSingleton sigleton = CSingleton.Instance();
            _students = sigleton.getStudentList();
        }
        public bool Add(CStudent item)
        {
            if(_students == null)
                return false;
            var result = GetById(item.Id);
            if(result != null)
            {
                return false;
            }
            else
            {
                _students.AddLast(item);
                return true;
            }
        }

        public bool Delete(string id)
        {
            var result = GetById(id);   
            if(result == null)
                return false;
            else
            {
                _students.Remove(result);
                return true;
            }
        }

        public List<CStudent> GetList()
        {
            return _students.ToList();
        }

        public CStudent GetById(string id)
        {
            foreach(var student in _students)
            {
                if(student.Id == id) 
                    return student;
            }
            return null;
        }
        public bool Update(string id, CStudent value)
        {
            var student = GetById(id);
            if (student != null)
            {
                student.Update = DateTime.Now;
                student.Name = value.Name;
                student.Dob = value.Dob;
                student.Address = value.Address;
                student.Email = value.Email;
                student.Phone = value.Phone;
                student.Picture = value.Picture;
                student.Gender = value.Gender;
                student.IsAdmin = value.IsAdmin;
                student.Password = value.Password;
                student.LearnCourses = value.LearnCourses;
                student.Update = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
