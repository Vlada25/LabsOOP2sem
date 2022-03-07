using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamLibrary;
using System;

namespace StreamTestProject
{
    [TestClass]
    public class MyStreamTest
    {
        private const string _fileToRead = @"..\file1.txt",
            _fileToWrite = @"..\file2.txt";

        [TestMethod]
        public void MyStream_Read_Test()
        {
            MyStream myStream = new MyStream(_fileToRead);

            Assert.ThrowsException<NotImplementedException>(() => myStream.Read());
        }

        [TestMethod]
        public void MyStream_Write_Test()
        {
            MyStream myStream = new MyStream(_fileToWrite);

            Assert.ThrowsException<NotImplementedException>(() => myStream.Write("some text"));
        }

        [TestMethod]
        [DataRow(1021)]
        public void MyFileStream_Read_Test(int expected)
        {
            MyStream myStream = new MyStream(_fileToRead);
            myStream = new MyFileStream(myStream);
            myStream.Read();

            Assert.AreEqual(expected, myStream.Text.Length);
        }

        [TestMethod]
        [DataRow(5)]
        public void MyBufferStream_Read_Test(int expected)
        {
            MyStream myStream = new MyStream(_fileToRead);
            myStream = new MyBufferStream(myStream);
            myStream.Read();

            Assert.AreEqual(expected, myStream.Text.Length);
        }

        [TestMethod]
        [DataRow(5)]
        public void MyMemoryStream_Read_Test(int expected)
        {
            MyStream myStream = new MyStream(_fileToRead);
            myStream = new MyMemoryStream(myStream);
            myStream.Read();

            Assert.AreEqual(expected, myStream.Text.Length);
        }
    }
}
