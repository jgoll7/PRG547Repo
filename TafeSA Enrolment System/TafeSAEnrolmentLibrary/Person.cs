using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Person
    {

        public Address PersonAddress { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String TelNum { get; set; }

        public Person(string name, string email, string telNum, Address address)
        {
            Name = name;
            Email = email;
            TelNum = telNum;
            PersonAddress = address;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email + " TelNum: " + TelNum + "\nAddress["+ PersonAddress+"]"; 
        }
    }
}
