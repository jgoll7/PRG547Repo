using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public sealed class Student : Person, IComparable<Student>
    {
        //assessor methods
        public Enrolment StudentEnrolment { get; set; }
        public String Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public int StudentID { get; set; }
        

        public Student(int studentID, string name, string email, string telNum, Address address, string program, DateTime dateRegistered, Enrolment enrolment) : base(name, email, telNum, address)
        {
            this.StudentID = studentID;
            this.Program = program;
            this.DateRegistered = dateRegistered;
            this.StudentEnrolment = enrolment;
        }

        public override string ToString()
        {
            return "Student[ID:"+ StudentID +" "+ base.ToString() + "]\nProgram["+ Program + ", Date Registered: "+ DateRegistered +"]\nEnrolment Details["+StudentEnrolment+"]";
        }

        // combine studentID and dateRegistered to create a more unique hashcode
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode() ^ this.Name.ToLower().GetHashCode();
        }

        //override Student Equals
        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == this.GetHashCode();
        }

        public int CompareTo(Student other)
        {
           return this.StudentID.CompareTo(other.StudentID);
        }

        //Override operators
        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }

        
    }
}
