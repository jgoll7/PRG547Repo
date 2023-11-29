using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    public class Course
    {
        public String CourseCode{ get; set; }
        public String CourseName{ get; set; }
        public float Cost{ get; set; }

        public Course(string courseCode, string courseName, float cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
        }

        public override string ToString()
        {
            return "Course Code: " + CourseCode + ", Course Name: " + CourseName + ", Cost: " + Cost;
        }
    }
}
