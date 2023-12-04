using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jackson Gollan - Assessment 2
namespace TafeSAEnrolmentLibrary
{
    [TestFixture]
    public class UnitTesting
    {
        protected Student s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;
        protected Student[] students;
        protected Course c1, c2, c3, c4, c5;
        protected LinkedList<Student> lList;
        protected LinkedListNode<Student> studentNode;
        protected DoublyLinkedList<Student> dLList;
        protected DoublyLinkedListNode<Student> dllStudentNode;
        protected BinaryTree<Student> studentTree;

        [SetUp]
        public void Setup()
        {
            Address a1 = new Address("11a", "Malcom Street", "5000", "SA");
            Address a2 = new Address("17", "Malcom Street", "5000", "SA");
            Address a3 = new Address("98", "Windy Lane", "5010", "NSW");
            Address a4 = new Address("222", "Westerlan Road", "5022", "WA");
            Address a5 = new Address("57", "Myron Street", "4441", "NT");
            c1 = new Course("SCN561", "Computer Science", 20000);
            c2 = new Course("JV521", "Java Programming", 11020);
            c3 = new Course("API11", "API Development", 9910);
            c4 = new Course("DAT513", "Database Design", 5100);
            c5 = new Course("SCN562", "Computer Science Practices", 11110);
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
            s5 = new Student(1, "Marka", "Marka@mail.com", "011143210", a5, "Cert IV Programming", new DateTime(), e5);
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

            //Create LinkedList
            lList = new LinkedList<Student>();
            foreach (Student student in students)
            {
                lList.Add(student);
            }

            //Create LinkedListNode
            s11 = new Student(11, "Wilder", "Winner@mail.com", "0478211930", null, "Cert IV Programming", new DateTime(), null);
            studentNode = new LinkedListNode<Student>(s11);

            //Create DoublyLinkedList
            dLList = new DoublyLinkedList<Student>();
            foreach (Student student in students)
            {
                lList.Add(student);
            }

            //Create DoublyLinkedListNode
            s12 = new Student(12, "Louis", "Armstrong@mail.com", "000000030", null, "Cert IV Programming", new DateTime(), null);
            dllStudentNode = new DoublyLinkedListNode<Student>(s12);

            //Create BinaryTree
            studentTree = new BinaryTree<Student>();
            foreach (Student student in students)
            {
                studentTree.Add(student);
            }

        }
    }
    [TestFixture]
    class OperatorTesting : UnitTesting
    {
        [Test]
        public void TestGreaterThan()
        {
            Assert.That(s1 > s2 == true);
        }

        [Test]
        public void TestLessThan()
        {
            Assert.That(s2 < s1 == true);
        }

        [Test]
        public void TestEqual()
        {
            Assert.That(s1 != s2 == true);
        }

        [Test]
        public void TestCompareTo()
        {
            Assert.That(s1.CompareTo(s2) > 0);
        }

        //Course Testing
        [Test]
        public void TestCourseGreaterThan()
        {
            Assert.That(c1 > c2 == true);
        }

        [Test]
        public void TestCourseLessThan()
        {
            Assert.That(c3 < c2 == true);
        }

        [Test]
        public void TestCourseEqual()
        {
            Assert.That(c1 != c3 == true);
        }

        [Test]
        public void TestCourseCompareTo()
        {
            Assert.That(c3.CompareTo(c1) < 0);
        }
    }
        //8.1 Testing Searching and Sorting
        [TestFixture]
    class SearchSortTesting : UnitTesting
    {
        [Test]
        public void TestLinearSearch()
        {
            int result;
            result = Search.LinearSearch(students, s4);
            Assert.That(students[result].Equals(s4));
        }

        [Test]
        // Search for student that does not exist
        public void TestBinarySearch()
        {
            int result;
            Student s11 = new Student(11, "Wilder", "Winner@mail.com", "0478211930", null, "Cert IV Programming", new DateTime(), null);
            result = Search.BinarySortedSearch(students, s11);
            Assert.That(result == -1);
        }

        [Test]
        //Sort array in alphabetical order
        public void TestBubbleSort()
        {
            Sort.BubbleSort(students);
            Assert.That(students[0].StudentID.Equals(1));
        }
    
    }
    //8.2 Testing Linked Lists Data Structures
    [TestFixture]
    class LinkedListTesting : UnitTesting
    {
        //8.2.1 Testing Linked List
        // a)
        [Test]
        public void TestLinkedListHead()
        {
            lList.AddFirst(studentNode);
            Assert.That(lList.Head == studentNode);
        }

        // b)
        [Test]
        // Add student at tail of list
        public void TestLinkedListTail()
        {
            lList.AddLast(studentNode);
            Assert.That(lList.Tail == studentNode);
        }

        //c)
        [Test]
        public void TestLinkedListFind()
        {
            lList.Add(s11);
            Assert.That(lList.Contains(s11));
        }

        // d)
        [Test]
        // Remove student from start of list
        public void TestLinkedListHeadRemove()
        {
            lList.AddFirst(studentNode);
            lList.RemoveFirst();
            Assert.That(!lList.Contains(s11));
        }

        // e)
        [Test]
        // Remove student from end of list
        public void TestLinkedListTailRemove()
        {
            lList.AddLast(studentNode);
            lList.RemoveLast();
            Assert.That(!lList.Contains(s11));
        }
    }

    //8.2.2 Testing Doubly Linked List
    // a)
    [TestFixture]
    class DoublyLinkedListTesting : UnitTesting
    {
        [Test]
        public void TestDoublyLinkedListHead()
        {
            dLList.AddFirst(dllStudentNode);
            Assert.That(dLList.Head == dllStudentNode);
        }

        // b)
        [Test]
        // Add student at tail of list
        public void TestDoublyLinkedListTail()
        {
            dLList.AddLast(dllStudentNode);
            Assert.That(dLList.Tail == dllStudentNode);
        }

        //c)
        [Test]
        public void TestDoublyLinkedListFind()
        {
            dLList.Add(s12);
            Assert.That(dLList.Contains(s12));
        }

        // d)
        [Test]
        // Remove student from start of list
        public void TestDoublyLinkedListHeadRemove()
        {
            dLList.AddFirst(dllStudentNode);
            dLList.RemoveFirst();
            Assert.That(!dLList.Contains(s12));
        }

        // e)
        [Test]
        // Remove student from end of list
        public void TestDoublyLinkedListTailRemove()
        {
            dLList.AddLast(dllStudentNode);
            dLList.RemoveLast();
            Assert.That(!dLList.Contains(s12));
        }
    }
    //8.3 Testing Binary Tree
    [TestFixture]
    class BinaryTesting : UnitTesting
    {
        //a)
        [Test]
        public void TestBinaryTreeFindSmallest()
        {

            Student foundMin = studentTree.FindSmallestValue();

            Assert.That(foundMin.StudentID == 1);
        }

        //b)
        [Test]
        public void TestBinaryFindLargest()
        {
            Student foundMax = studentTree.FindLargestValue();

            Assert.That(foundMax.StudentID == 10);
        }

        //c)
        [Test]
        public void TestBinaryFind()
        {
            Node<Student> foundNode = studentTree.Find(s10);
            Student found = foundNode.Data;
            Assert.That(found.StudentID == 10);
        }

        //d)
        [Test]
        public void TestBinaryDelete()
        {

            Node<Student> result;

            studentTree.Remove(s10);
            result = studentTree.Find(s10);
            ClassicAssert.IsNull(result);
        }
    }
}
