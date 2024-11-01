using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_Introduction
{
    //polymorphism
    public class Student
    {
        public string FirstName = "Ben";
        public string LastName = "Awo";
        public int num = 677;
        public int num2 = 456;

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " "+ LastName);
        }

        public virtual void PrintName()
        {
            Console.WriteLine(num * num2); 
        }
    }


    public class StudentList : Student
    {
        public override void PrintFullName()
        {
            Console.WriteLine("Studentlist contain" + FirstName + " " + LastName);
        }
    }

    public class Studentinfo : Student
    {

        public override void PrintFullName()
        {
            Console.WriteLine("Studentinfo contain" + FirstName + " " + LastName);
        }

    }




}
