using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStudent()
        {
            Student s = new Student();
            s.Score = 10;
            Assert.AreEqual('A', s.getLetterScore());

        }
        [TestMethod]
        public void TestStudent1()
        {
            Student s = new Student();
            s.Score = 8;
            Assert.AreEqual('A', s.getLetterScore());

        }
        [TestMethod]
        public void TestStudent2()
        {
            Student s = new Student();
            s.Score = 7;
            Assert.AreEqual('B', s.getLetterScore());

        }
        [TestMethod]
        public void TestStudent3()
        {
            Student s = new Student();
            s.Score = 5;
            Assert.AreEqual('C', s.getLetterScore());

        }
        [TestMethod]
        public void TestStudent4()
        {
            Student s = new Student();
            s.Score = 4;
            Assert.AreEqual('D', s.getLetterScore());

        }

        [TestMethod]
        public void TestStudent5()
        {
            Student s = new Student();
            s.Score = 3.5;
            Assert.AreEqual('D', s.getLetterScore());

        }

        [TestMethod]
        public void TestStudent6()
        {
            Student s = new Student();
            s.Score = 2;
            Assert.AreEqual('E', s.getLetterScore());

        }
    }
}
