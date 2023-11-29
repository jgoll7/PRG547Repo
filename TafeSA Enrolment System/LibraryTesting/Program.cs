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
            Console.WriteLine("\nTesting Sorting Algorithm(Alphabetical(Asc)");
            Student[] students = { s1, s2, s3, s4 };
            Sort.SelectionSortAsc(students);
            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine(student + " ");
            }

            // Sort Descending
            Console.WriteLine("\nTesting Sorting Algorithm(Alphabetical(Desc)");
            Sort.SelectionSortDesc(students);
            foreach (Student student in students)
            {
                Console.WriteLine();
                Console.WriteLine(student + " ");
            }

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

            Console.ReadKey();
        }
    }
}
