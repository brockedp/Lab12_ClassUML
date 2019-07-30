using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }
        public Staff()
        {
                
        }

        public Staff(string school, double pay, 
            string name, string address)
            : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff:{Name},{Address},{School},{Pay}";
        }
    }
}
