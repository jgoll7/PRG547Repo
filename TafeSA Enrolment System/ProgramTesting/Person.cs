using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTesting
{
    public class Person
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String TelNum { get; set; }

        public Person(string name, string email, string telNum)
        {
            Name = name;
            Email = email;
            TelNum = telNum;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email + " TelNum: " + TelNum; 
        }
    }
}
