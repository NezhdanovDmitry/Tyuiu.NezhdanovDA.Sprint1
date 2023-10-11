using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NezhdanovDA.Sprint1.Task4.V9.Lib;


namespace Tyuiu.NezhdanovDA.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Double x = 1;
            Double y = 389;
            Double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
