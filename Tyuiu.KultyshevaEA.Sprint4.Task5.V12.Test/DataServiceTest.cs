using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KultyshevaEA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 0,1,-3,-2,4},
                                          { -5,-4,-3,-2,-1},
                                          {1,2,3,4,0 },
                                          {-6,-5,-4,-3,-2 },
                                          {0,1,2,3,4 }    };

            int res = ds.Calculate(mas2);
            int wait = 12;

            Assert.AreEqual(wait, res);

        }
    }
}
