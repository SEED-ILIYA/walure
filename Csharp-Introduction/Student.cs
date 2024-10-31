using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    //extension method
   public static class Student 
    {
      public static bool IsGreater(this int i, int  i2)
        {
            return i > i2;
        }
    }


}
