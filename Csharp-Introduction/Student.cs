using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    //accessmodifier
    //1.private
    //2.public
    //3.internal
    //4. protected
    class Student
    {
        //members  
        //field
        //properties
        //method
        //constructor
        //destructor
        //indexers

        public int v = 90; //field
        public string Name { get; set; } //property

        public static void MyMethod1()
        {

        }

        public static void MyMethod2(int i, int x)
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
