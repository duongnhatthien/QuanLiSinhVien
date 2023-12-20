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
    internal class CHandleCourse : IHandle<CCourse>
    {
        private static LinkedList<CCourse> list;
        public CHandleCourse()
        {
            CSingleton sigleton = CSingleton.Instance();
            list = sigleton.getCourseList();
        }
        public bool Add(CCourse item)
        {
            if (list == null)
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

        public CCourse GetById(string id)
        {
            foreach (var item in list)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public List<CCourse> GetList()
        {
            return list.ToList();
        }

        public bool Update(string id, CCourse value)
        {
            var item = GetById(id);
            if (item != null)
            {
                item.Name = value.Name;
                item.Update = DateTime.Now;
                item.Create = DateTime.Now;
                item.Date = value.Date;
                item.EndTime = value.EndTime;
                item.StartTime = value.StartTime;
                item.Students = value.Students;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
