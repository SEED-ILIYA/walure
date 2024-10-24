using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    //abstract class
    public abstract class Calculate 
    {
        int id; //field

        string name {  get; set; } //property

        //abstract method
        public abstract void MyMethod();

        //noneabstract method
        public void Print()
        {
            Console.WriteLine("welcome to the abstract class");
        }
       
    }
}
