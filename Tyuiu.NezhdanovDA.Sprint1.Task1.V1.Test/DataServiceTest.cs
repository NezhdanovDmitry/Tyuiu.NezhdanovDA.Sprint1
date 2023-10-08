using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NezhdanovDA.Sprint1.Task1.V1.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 3.0;
            double y = 1.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(7, res);
        }
    }
}
