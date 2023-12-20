using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Model
{
    [Serializable]
    public class CCommon
    {
        protected string _id;
        protected string _name;
        protected DateTime _update;
        protected DateTime _create;

        public CCommon(string id, string name, DateTime update, DateTime create)
        {
            _id = id;
            _name = name;
            _update = update;
            _create = create;
        }

        public CCommon():this("","",new DateTime(),DateTime.Now)
        {
        }

        public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Update { get => _update; set => _update = value; }
        public DateTime Create { get => _create; set => _create = value; }
    }
}
