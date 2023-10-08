using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NezhdanovDA.Sprint1.Task2.V1.Lib;
namespace Tyuiu.NezhdanovDA.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int Km = 1609;
            var res = Km / 1609;
            Assert.AreEqual(1, res);
        }
    }
}
