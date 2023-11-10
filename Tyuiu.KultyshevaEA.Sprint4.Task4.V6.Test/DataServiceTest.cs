using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint4.Task4.V6.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
            { 7, 6, 6, 6, 9 },
            { 4, 4, 4, 9, 4 },
            { 5, 5, 5, 6, 5 },
            { 4, 9, 5, 9, 7 },
            { 6, 9, 5, 6, 7 }
        };

            int[,] wait = new int[5, 5] {
            { 0, 6, 6, 6, 0 },
            { 4, 4, 4, 0, 4 },
            { 0, 0, 0, 6, 0 },
            { 4, 0, 0, 0, 0 },
            { 6, 0, 0, 6, 0 }
        };

            int[,] result = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
