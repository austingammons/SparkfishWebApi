using Microsoft.VisualStudio.TestTools.UnitTesting;
using SparkfishWebApi.Models;
using SparkfishWebApi.Services;
using System;
using System.Linq;

namespace SparkfishWebApiUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexOfRange(int min, int max, int index)
        {
            Listify<int> ls = new Listify<int>();

            IncomingListifyModel model = new IncomingListifyModel()
            {
                Min = 100,
                Max = 200,
                Index = 50
            };

            int target = ls.IndexOfRange(Enumerable.Range(model.Min, model.Max), model.Index);

            int a = 0;
        }
    }
}
