using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Domain Model Design
            Address a = new Address("11a", "Malcom Street", "5000", "SA");
            Course c = new Course("SCN561", "Advanced Science", 20000);
            Enrolment e = new Enrolment(new DateTime(2023,11,04),"8",2,c);
            Student s1 = new Student(1, "Susan ", "Susan@mail.com ", "04911330 ", a, "Cert IV Programming ", new DateTime(2023,11,03),e);
            Console.WriteLine(s1);

            // PART 1 - Generic double linked list
            // Test DoublyLinkedList
            Console.WriteLine("\nTesting DoublyLinkedList");
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(7);
            list.AddLast(1);
            list.AddLast(11);
            list.AddFirst(9);
            list.AddLast(100);

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

            // PART 3 - Sorting
            Student s2 = new Student(2, "Willik", "Mark@mail.com", "04940930", a, "Cert IV Programming", new DateTime(), e);
            Student s3 = new Student(3, "Malek", "Malek@mail.com", "04312093", a, "Cert IV Programming", new DateTime(), e);
            Student s4 = new Student(4, "Aaron", "Aaronk@mail.com", "04931913", a, "Cert IV Programming", new DateTime(), e);

            // Sort Ascending
            Console.WriteLine("\nTesting Sorting Algorithm(Alphabetical(Asc))");
            Student[] students = { s1, s2, s3, s4 };
            Sort.SelectionSortAsc(students);
            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine(student + " ");
            }

            // Sort Descending
            Console.WriteLine("\nTesting Sorting Algorithm(Alphabetical(Desc))");
            Sort.SelectionSortDesc(students);
            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine(student + " ");
            }

            Console.WriteLine("\nBUBBLE)");
            Sort.BubbleSort(students);
            Console.WriteLine(students[0].StudentID);
            Console.WriteLine("FILLER");

            // PART 4 - Searchin
            int result;

            //Binary Search (Sorted)
            result = Search.BinarySortedSearch(students, s1);
            if (result > 0)
            {
                Console.WriteLine("Found at Index: " + result);
            }
            else
            {
                Console.WriteLine("Not Found.");
            }

            //Linear Search
            result = Search.LinearSearch(students, s1);
            if (result > 0)
            {
                Console.WriteLine("Found at Index: " + result);
            }
            else
            {
                Console.WriteLine("Not Found.");
            }

            //BTREE

            BinaryTree<Student> studentTree = new BinaryTree<Student>();
            Student  s5, s6, s7, s8, s9, s10;
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
            s1 = new Student(1, "Mark", "Mark@mail.com", "04943210", a5, "Cert IV Programming", new DateTime(), e1);
            s2 = new Student(2, "James", "James@mail.com", "04940930", a1, "Cert IV Programming", new DateTime(), e2);
            s3 = new Student(3, "Julie", "Julie@mail.com", "04111930", a2, "Cert IV Programming", new DateTime(), e3);
            s4 = new Student(4, "Aaron", "Aaron@mail.com", "049430930", a3, "Cert IV Programming", new DateTime(), e4);
            s5 = new Student(5, "Marka", "Marka@mail.com", "0494311210", a5, "Cert IV Programming", new DateTime(), e5);
            s6 = new Student(6, "Wendy", "Wendy@mail.com", "0664930", a2, "Cert IV Programming", new DateTime(), e6);
            s7 = new Student(7, "Oscar", "Oscar@mail.com", "04660930", a4, "Cert IV Programming", new DateTime(), e7);
            s8 = new Student(8, "Mike", "Mike@mail.com", "04977430", a1, "Cert IV Programming", new DateTime(), e8);
            s9 = new Student(9, "Mary", "Mary@mail.com", "049113930", a5, "Cert IV Programming", new DateTime(), e9);
            s10 = new Student(10, "Janine", "Janine@mail.com", "04782930", a3, "Cert IV Programming", new DateTime(), e10);

            Student[] treeStudents;
            treeStudents = new Student[10];
            //populate array
            treeStudents[0] = s1;
            treeStudents[1] = s2;
            treeStudents[2] = s3;
            treeStudents[3] = s4;
            treeStudents[4] = s5;
            treeStudents[5] = s6;
            treeStudents[6] = s7;
            treeStudents[7] = s8;
            treeStudents[8] = s9;
            treeStudents[9] = s10;

            foreach (Student student in treeStudents)
            {
                studentTree.Add(student);
            }
            Console.WriteLine("\nTESTING TRAVERSAL");
            studentTree.TraverseInOrder(studentTree.Root);
            Console.ReadKey();
        }
    }
}
