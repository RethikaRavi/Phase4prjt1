using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SchoolManagement
    {
        static List<School> list = new List<School>()
        {
            new School(){StuId=1,StuName="Arun",TeacherName="latha",SubName="Science"},
            new School(){StuId=2,StuName="Charu",TeacherName="Diya",SubName="Social"},
            new School(){StuId=3,StuName="Ram",TeacherName="Ramesh",SubName="Chemistry"},
            new School(){StuId=4,StuName="Jaanu",TeacherName="vinith",SubName="Physics"},
            new School(){StuId=5,StuName="Sam",TeacherName="Deepan",SubName="Mathematics"},
        };
        public List<School> AllStulist()
        {
            return list;
        }
        public List<School> SearchStu(int id)
        {
            List<School> searchlist = list.FindAll(s => s.StuId == id);
            return searchlist;
        }
        public virtual bool StudentMarks()
        {
            return false;
        }
    }
}
