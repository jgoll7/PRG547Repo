using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Enrolment
    {
        public Course CourseEnrolment { get; set; }
        public DateTime DateEnrolled { get; set; }
        public String Grade { get; set; }
        public int Semester { get; set; }

        public Enrolment(DateTime dateEnrolled, string grade, int semester, Course course)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            CourseEnrolment = course;
        }

        public override string ToString()
        {
            return "Date Enrolled: " + DateEnrolled + ", Grade: " + Grade + ", Semester: " + Semester+ "\nCourse["+CourseEnrolment+"]";
        }
    }
}
