using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    public class PersonalInfo
    {
        public static string Name;
        public static int Age;

        public static void MyMethod()
        {
            Console.WriteLine("Hello there");
        }

        public void MyMethod1()
        {
            Console.WriteLine("Welcome Back");
        }
    }

    public enum DaysOfTheWeek
    {
        Monday=2,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Gender
    { 
        Male = 5,
        Female,
        Unknown
    }


}
