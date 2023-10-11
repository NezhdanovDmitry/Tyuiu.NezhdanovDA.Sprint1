using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NezhdanovDA.Sprint1.Task4.V0.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Double x = 2;
            Double y = 2;
            Double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
