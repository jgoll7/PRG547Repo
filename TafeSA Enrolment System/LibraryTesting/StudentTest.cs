using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentLibrary
{
    [TestFixture]
    class StudentTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestStudent()
        {
            Student s1 = new Student(1, "Mark", "Mark@mail.com", "04940930", "Cert IV Programming", new DateTime());
            Student s2 = new Student(1, "Mark", "Mark@mail.com", "04940930", "Cert IV Programming", new DateTime());
            Assert.That(s1 != s2);
        }
        
    }
}
