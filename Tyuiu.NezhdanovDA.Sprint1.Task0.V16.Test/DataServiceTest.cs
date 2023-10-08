using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NezhdanovDA.Sprint1.Task0.V16.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}
