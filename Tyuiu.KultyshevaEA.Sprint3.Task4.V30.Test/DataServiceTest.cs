using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KultyshevaEA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KultyshevaEA.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1.924;

            Assert.AreEqual(wait, res);

        }
    }
}
