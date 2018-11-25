using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaikCourseCapstone
{
    class Class2
    {
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        public static string gets1()
        {
            return studentname;
        }

        public static void sets1(String stdname)
        {
            studentname = stdname;
        }

        public static int getnocours()
        {
            return courseno;

        }

        public static void setsnocours(int course)
        {
            courseno = course;

        }

        public static DateTime getdate()
        {
            return dateTime;

        }

        public static void setdate(DateTime dtTime)
        {
            dateTime = dtTime;
        }

        public static string gettype()
        {
            return type2;

        }

        public static void settype(string Type)
        {
            type2 = Type;
            gettype();
        }
    }
}
