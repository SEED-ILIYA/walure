using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    internal class Calculator
    {
        [Obsolete("this method is old, please make use of the new method with more flexible")]
        public static int Addition(int v1, int v2)
        {   
            return v1 + v2; 
        }

        public static int Addition(int v1, int v2, int v3)
        {
            return (v1 + v2) + (v1 * v3);
        }
    }
}
