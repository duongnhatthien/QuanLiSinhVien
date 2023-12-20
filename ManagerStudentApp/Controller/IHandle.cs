using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Controller
{
    internal interface IHandle<T>
    {        List<T> GetList();
        T GetById(string id);
        bool Add(T item);
        bool Update(string id, T value);
        bool Delete(string id);
    }
}
