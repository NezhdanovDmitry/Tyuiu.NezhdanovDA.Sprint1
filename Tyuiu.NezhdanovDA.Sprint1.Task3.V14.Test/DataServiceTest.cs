using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NezhdanovDA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.NezhdanovDA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 345;
            int wait = 543;
            var res = ds.ReverseNumber(number);
            Assert.AreEqual(wait, res);
           
        }
    }
}
