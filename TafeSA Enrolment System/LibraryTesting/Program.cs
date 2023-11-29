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
            Address a = new Address("11a", "Malcom Street", "5000", "SA");
            Course c = new Course("SCN561", "Advanced Science", 20000);
            Enrolment e = new Enrolment(new DateTime(2023,11,04),"8",2,c);
            Student s1 = new Student(1, "Mark ", "Mark@mail.com ", "04940930 ", a, "Cert IV Programming ", new DateTime(2023,11,03),e);
            Console.WriteLine(s1);


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
            Console.ReadKey();
        }
    }
}
