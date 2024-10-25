using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
   public delegate bool StudentCheck(Student stud);
   public class Student 
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Salary { get; set; }
        public int Level {  get; set; }
    }


}
