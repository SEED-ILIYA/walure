using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    //derived class
    class Student : Calculate
    {
        public override void MyMethod()
        {
            Console.WriteLine("this is abtract method");
        }
    }


}
