using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint3.TaskReview.V8.Lib;

namespace Tyuiu.BelovaEA.Sprint3.TaskReview.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = 0;
            int stop = 2;
            int len = 3;
            double[] array;
            array = new double[len];

            array[0] = 1;
            array[1] = 4.38;
            array[2] = 0;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(array, res);
        }
    }
}

