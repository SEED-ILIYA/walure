using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
   //static and Nonstatic/instance
    class Student
    {
        string Name;
        int Age;
        public Student(string myname, int myage)
        {
            Name = myname;
            Age = myage;
        }
        public void MyMethod1()
        {
            Console.WriteLine("My Name is {0}, i'm {1} years old", Name, Age);
        }

        public void MyMethod2(int i, int x)
        {

        }

        public static int MyMethod3()
        {
            return 78;
        }
        public static string MyMethod4( string v1, int v2)
        {
            return v1;
        }

    }
}
