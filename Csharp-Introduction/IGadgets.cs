using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
    public interface IGadgets
    {
       void MyMethod();
       void MyMethod(string method);
       string MyMethod2();

    }

    public interface IAnimal : IGadgets
    {
        void Sound();
        void BodyParts();
    
    
    }

}
