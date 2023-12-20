using ManagerStudentApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentApp.Controller
{
    [Serializable]
    internal class CSingleton
    {
        private static string filePath = "data.dat";
        private static BinaryFormatter bf = new BinaryFormatter();
        private static CSingleton _instance = null;

        private LinkedList<CClassroom> _classroomList;
        private LinkedList<CCourse> _courceList;
        private LinkedList<CInstuctor> _instuctorList;
        private LinkedList<CStudent> _studentList;
        private LinkedList<CGrade> _gradeList;

        private CSingleton()
        {
            _classroomList = new LinkedList<CClassroom>();
            _courceList = new LinkedList<CCourse>();
            _studentList = new LinkedList<CStudent>();
            _instuctorList = new LinkedList<CInstuctor>();
            _gradeList = new LinkedList<CGrade>();
        }

        public static CSingleton Instance()
        {
            if( _instance == null )
                return new CSingleton();
            return _instance;
        }

        public LinkedList<CClassroom> getClassroomList() => _classroomList;
        public LinkedList<CCourse> getCourseList() => _courceList;
        public LinkedList<CStudent> getStudentList() => _studentList;
        public LinkedList<CInstuctor> getInstuctorList() => _instuctorList;
        public LinkedList<CGrade> getGradeList() => _gradeList;

        public static bool LoadFile()
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                _instance = bf.Deserialize(fs) as CSingleton;
                fs.Close();
                return true;
            }
            catch
            {
                _instance = new CSingleton();
                return false;
            }
        }

        public static bool SaveFile()
            {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                bf.Serialize(fs, _instance);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
         
    }
}
