using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Address
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address(string number, string street, string postcode, string state)
        {
            Number = number;
            Street = street;
            Postcode = postcode;
            State = state;
        }

        public override string ToString()
        {
            return Number + " " + Street + ", " + Postcode + ", " + State;
        }
    }
}
