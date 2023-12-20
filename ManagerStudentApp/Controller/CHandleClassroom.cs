using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Controller
{
    internal class CHandleClassroom : IHandle<CClassroom>
    {
        private static LinkedList<CClassroom> list = new LinkedList<CClassroom>();
        public CHandleClassroom()
        {
            CSingleton sigle = CSingleton.Instance();
            list = sigle.getClassroomList();
        }
        public bool Add(CClassroom item)
        {
            if (item == null)
                return false;
            var result = GetById(item.Id);
            if (result != null)
            {
                return false;
            }
            else
            {
                list.AddLast(item);
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
                list.Remove(result);
                return true;
            }
        }

        public CClassroom GetById(string id)
        {
            foreach (CClassroom student in list)
            {
                if (string.Compare(student.Id, id) == 0)
                    return student;
            }
            return null;
        }

        public List<CClassroom> GetList()
        {
            return list.ToList();
        }

        public bool Update(string id, CClassroom value)
        {
            var classroom = GetById(id);
            if (classroom != null)
            {
                classroom.Update = DateTime.Now;
                classroom.Name = value.Name;
                classroom.Students = value.Students;
                classroom.Instuctor = value.Instuctor;
                classroom.Create = value.Create;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
