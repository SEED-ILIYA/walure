using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    public class PersonalInfo : Courseinfo
    {
        public static string Name;
        public static int Age;

        public static void MyMethod()
        {
            Console.WriteLine("Hello there");
        }

        public  void MyMethod1()
        {
            Console.WriteLine("Welcome Back");
        }
    }

    public class Courseinfo
    {
        public static string CourseName;

    }

}
