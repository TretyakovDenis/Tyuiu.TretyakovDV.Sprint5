using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace Tyuiu.TretyakovDV.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Денис\source\repos\Tyuiu.TretyakovDV.Sprint5\Tyuiu.TretyakovDV.Sprint5.Task1.V18\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
