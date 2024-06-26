using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_POO_intro
{
    internal class Person
    {
        private string _name;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        public int Age {  get; set; }


    }
}
