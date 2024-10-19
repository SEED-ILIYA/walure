using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    public class Calculate<T>
    {
        public T[] values = new T[5]; //generic array
        int count = 0;
       
        public void Add (T data) //generic method
        {
            if(count + 1 < 6)
            {
                values[count] = data;

            }
            count++;    
        }

      
    }
}
