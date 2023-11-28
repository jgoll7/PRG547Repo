using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    public sealed class Student : Person
    {
        //assessor methods
        public String Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public int StudentID { get; set; }

        public Student(int studentID, string name, string email, string telNum, string program, DateTime dateRegistered) : base(name, email, telNum)
        {
            this.StudentID = studentID;
            this.Program = program;
            this.DateRegistered = dateRegistered;
        }

        public override string ToString()
        {
            return "StudentID: "+ StudentID + base.ToString() + "Program: "+ Program + "Date Registered: "+ DateRegistered;
        }
    }
}
