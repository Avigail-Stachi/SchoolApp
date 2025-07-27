using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    public static class DbManager
    {
        public static string GetConnectionString()
        {
            return "Data Source=School.db;Version=3;";
        }
    }
}
