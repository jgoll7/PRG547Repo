using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    [TestFixture]
    class UnitTesting
    {
        private Student s1,s2,s3,s4,s5,s6,s7,s8,s9,s10;
        private Student[] students;
        [SetUp]
        public void Setup()
        {
            Address a1 = new Address("11a", "Malcom Street", "5000", "SA");
            Address a2 = new Address("17", "Malcom Street", "5000", "SA");
            Address a3 = new Address("98", "Windy Lane", "5010", "NSW");
            Address a4 = new Address("222", "Westerlan Road", "5022", "WA");
            Address a5 = new Address("57", "Myron Street", "4441", "NT");
            Course c1 = new Course("SCN561", "Computer Science", 20000);
            Course c2 = new Course("JV521", "Java Programming", 11020);
            Course c3 = new Course("API111", "API Development", 9910);
            Course c4 = new Course("DAT513", "Database Design", 5100);
            Course c5 = new Course("SCN562", "Computer Science Practices", 11110);
            Enrolment e1 = new Enrolment(new DateTime(2023, 10, 04), "12", 1, c1);
            Enrolment e2 = new Enrolment(new DateTime(2023, 10, 04), "11", 1, c5);
            Enrolment e3 = new Enrolment(new DateTime(2023, 11, 04), "11", 1, c5);
            Enrolment e4 = new Enrolment(new DateTime(2023, 11, 04), "10", 1, c3);
            Enrolment e5 = new Enrolment(new DateTime(2023, 11, 04), "10", 1, c2);
            Enrolment e6 = new Enrolment(new DateTime(2023, 4, 04), "10", 2, c2);
            Enrolment e7 = new Enrolment(new DateTime(2023, 5, 04), "12", 2, c1);
            Enrolment e8 = new Enrolment(new DateTime(2023, 5, 04), "11", 2, c4);
            Enrolment e9 = new Enrolment(new DateTime(2023, 5, 04), "12", 2, c1);
            Enrolment e10 = new Enrolment(new DateTime(2023, 4, 04), "11", 2, c4);
            //create student objects
            s1 = new Student(5, "Mark", "Mark@mail.com", "04943210", a5, "Cert IV Programming", new DateTime(), e1);
            s2 = new Student(2, "James", "James@mail.com", "04940930", a1, "Cert IV Programming", new DateTime(), e2);
            s3 = new Student(3, "Julie", "Julie@mail.com", "04111930", a2, "Cert IV Programming", new DateTime(), e3);
            s4 = new Student(4, "Aaron", "Aaron@mail.com", "049430930", a3, "Cert IV Programming", new DateTime(), e4);
            s5 = new Student(5, "Mark", "Mark@mail.com", "04943210", a5, "Cert IV Programming", new DateTime(), e5);
            s6 = new Student(6, "Wendy", "Wendy@mail.com", "0664930", a2, "Cert IV Programming", new DateTime(), e6);
            s7 = new Student(7, "Oscar", "Oscar@mail.com", "04660930", a4, "Cert IV Programming", new DateTime(), e7);
            s8 = new Student(8, "Mike", "Mike@mail.com", "04977430", a1, "Cert IV Programming", new DateTime(), e8);
            s9 = new Student(9, "Mary", "Mary@mail.com", "049113930", a5, "Cert IV Programming", new DateTime(), e9);
            s10 = new Student(10, "Janine", "Janine@mail.com", "04782930", a3, "Cert IV Programming", new DateTime(), e10);
            
            //initialise array
            students = new Student[10];
            //populate array
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
            students[4] = s5;
            students[5] = s6;
            students[6] = s7;
            students[7] = s8;
            students[8] = s9;
            students[9] = s10;

        }
        
        [Test]
        public void TestStudent()
        {
            Assert.That(students[0] != students[1]);
            Assert.That(students[0].Equals(students[4]));
        }
        //8.1 Testing Searching and Sorting

        [Test]
        public void TestLinearSearch()
        {
            int result;
            result = Search.LinearSearch(students, s4);
            Assert.That(students[result].Equals(s4));
        }

        [Test]
        public void TestBinarySearch()
        {
            int result;
            Student s11 = new Student(11, "Wilder", "Winner@mail.com", "0478211930", null, "Cert IV Programming", new DateTime(), null);
            result = Search.BinarySortedSearch(students, s11);
            Assert.That(result == -1);
        }

        [Test]
        public void TestBubbleSort()
        {
            int result;
            Sort.BubbleSort(students);
            Assert.That(students[0].Name == "Aaron");
        }

        //8.2 Testing Linked Lists Data Structures
        [Test]
        public void TestLinkedList()
        {
            LinkedList<Student> lList = new LinkedList<Student>();
            foreach(Student student in students)
            {
                lList.Add(student);
            }

            Student s11 = new Student(11, "Wilder", "Winner@mail.com", "0478211930", null, "Cert IV Programming", new DateTime(), null);
            lList.AddFirst(s11);

            Assert.That(lList.Contains(s11));
        }


    }
}
