using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint4.Task1.V5.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 60;

            Assert.AreEqual(wait, res);
        }
    }
}
