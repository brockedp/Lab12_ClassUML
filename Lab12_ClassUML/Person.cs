using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Person
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
       
        public override string ToString()
        {
            return $"Student:{Name},{Address}";
        }
    }
}
