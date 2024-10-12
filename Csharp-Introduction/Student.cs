using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
   //derived class
    class Student : PersonalInfo, IGadgets,IAnimal
    {
        public static int StudentAge()
        {
            return 78;
        }
        public static string StudentCourse( string v1, int v2)
        {
            return v1;
        }

        public void BodyParts()
        {
            throw new NotImplementedException();
        }

        public void MyMethod()
        {
            Console.WriteLine("");
        }

        public void MyMethod(string method)
        {
            throw new NotImplementedException();
        }

        public string MyMethod2()
        {
            throw new NotImplementedException();
        }

        public void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
