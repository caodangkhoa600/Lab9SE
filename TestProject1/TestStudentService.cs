using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;
using System;

namespace TestProject1
{
    [TestClass]
    public class TestStudentService
    {
        [TestMethod]
        public void TestStudent()
        {
            StudentService s = new StudentService();
            bool t = s.addStudent(new Student()
            {
                Id = 1,
                Name = "asd",
                Score = 10,
            });
            Assert.IsTrue(t);
        }

        [TestMethod]
        public void TestStudent1()
        {
            StudentService s = new StudentService();
            Student student = new Student()
            {
                Id = 1,
                Name = "asd",
                Score = 10,
            };
            bool t = s.addStudent(student);
            t = s.addStudent(student);
            Assert.IsFalse(t);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudent2()
        {
            StudentService s = new StudentService();
            s.addStudent(null);
        }

        [TestMethod]
        public void TestStudent3()
        {
            StudentService s = new StudentService();
            int t = 0;
            s.addStudent(new Student()
            {
                Id = t++,
                Name = "asd",
                Score = 10,
            });
            s.addStudent(new Student()
            {
                Id = t++,
                Name = "asd",
                Score = 10,
            });
            s.addStudent(new Student()
            {
                Id = t++,
                Name = "asd",
                Score = 10,
            });
            Assert.AreEqual(3, s.size());
        }

        [TestMethod]
        public void TestStudent4()
        {
            StudentService s = new StudentService();
            int t = 0;
            s.addStudent(new Student()
            {
                Id = t,
                Name = "asd",
                Score = 10,
            });
            s.addStudent(new Student()
            {
                Id = t,
                Name = "asd",
                Score = 10,
            });
            s.addStudent(new Student()
            {
                Id = t,
                Name = "asd",
                Score = 10,
            });
            Assert.AreEqual(1, s.size());
        }

    }
}
