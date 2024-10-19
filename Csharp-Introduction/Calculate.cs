using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Introduction
{
     struct Calculate 
    {
        private int id;
        private string name;

        public int Id //property
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name //property
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //constructor
        public Calculate(int id, string name)
        {
            this.id = id;
            this.name = name;

        }


        public void ReadDetails()
        {
            Console.WriteLine("Id = {0} && the name = {1}",this.id,this.name);
        }

    }
}
