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

        // combine CourseCode and CourseName to create a more unique hashcode
        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode() ^ this.CourseName.ToLower().GetHashCode();
        }

        //override Course Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Course course = obj as Course;
            return this.GetHashCode() == course.GetHashCode();
        }

        public int CompareTo(Course other)
        {
            return this.CourseCode.CompareTo(other.CourseCode);
        }

        //Override operators
        public static bool operator ==(Course x, Course y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Course x, Course y)
        {
            return !object.Equals(x, y);
        }

        public static bool operator >(Course x, Course y)
        {
            int result;
            result = x.CourseCode.CompareTo(y.CourseCode);
            if (result > 0)
            {
                return true;

            }
            else
                return false;
        }

        public static bool operator <(Course x, Course y)
        {
            int result;
            result = x.CourseCode.CompareTo(y.CourseCode);
            if (result < 0)
            {
                return true;

            }
            else
                return false;
        }
    }
}
