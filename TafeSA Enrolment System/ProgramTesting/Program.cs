using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(1, "Mark Marky", "marky@mail.com", "891819290", "Cert IV Information Technology", new DateTime());
            Console.WriteLine(stud1);
        }
    }
}
