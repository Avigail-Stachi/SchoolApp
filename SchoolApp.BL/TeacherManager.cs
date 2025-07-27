using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.DAL;


namespace SchoolApp.BL
{
    public class TecherManager

    {
        public static List<Teacher> GetAllSTeachers()
        {
            return TeacherDal.GetTeachers();
        }

        public static Teacher GetTeacherByID(int id)
        {
            return GetAllSTeachers().Where(s => s.ID == id).FirstOrDefault();
        }
    }
}
