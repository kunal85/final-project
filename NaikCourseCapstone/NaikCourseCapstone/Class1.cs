using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaikCourseCapstone
{
    public static class Class1
    {
        private static string studname;
        private static int nocourse;
        private static DateTime dateTime;
        private static string type;



        public static void gets1()
        {
            Class2.sets1(studname);
            
        }

        public static void  sets1(String sname)
        {
            studname = sname;
            gets1();
        }

        public static void getnocours()
        {
            Class2.setsnocours(nocourse);

        }

        public static void setsnocours(int course)
        {
            nocourse = course;
            getnocours();
        }

        public static void getdate()
        {
            Class2.setdate(dateTime);

        }

        public static void setdate(DateTime dtTime)
        {
            dateTime = dtTime;
            getdate();
        }

        public static void gettype()
        {
            Class2.settype(type);

        }

        public static void settype(string Type)
        {
            type = Type;
            gettype();
        }
    }
}
