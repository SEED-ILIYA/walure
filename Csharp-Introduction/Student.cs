using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    /// <summary>
    /// this clas is a static class and it has extension method in it
    /// </summary>
    public static class Student
    {
        /// <summary>
        /// this method is an extension that check for interger variables
        /// </summary>
        /// <param name="i"></param>
        /// <param name="i2"></param>
        /// <returns>bool</returns>
        public static bool IsGreater(this int i, int i2)
        {
            return i > i2;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void MyMethod()
        {

        }
        #region this method is to be refactored later
        public static void MyMethod2()
        {
            Console.WriteLine("Hello World");
        }
        #endregion
    }


}
