using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
   //derived class
    class Student : PersonalInfo 
    {
        public static int StudentAge()
        {
            return 78;
        }
        public static string StudentCourse( string v1, int v2)
        {
            return v1;
        }

    }
}
