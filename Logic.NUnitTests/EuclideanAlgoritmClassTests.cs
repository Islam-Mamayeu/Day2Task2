using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;


namespace Logic.NUnitTests
{
    [TestFixture]
    public class EuclideanAlgoritmClassTests
    {
        [TestCase(1000,575,Result = 25)]

        public int EuclideanAlgoritmTest(int a,int b)
        {
            Stopwatch timer = new Stopwatch();
            int actResult = EuclideanAlgoritmClass.Algoritm(timer,a,b);
            return actResult;
        }

        [TestCase(1000, 575,746, Result = 1)]
        [TestCase(0, 575, 746, ExpectedException =typeof( ArgumentException))]
        [TestCase(423, 575, -234, Result = 1)]

        public int EuclideanAlgoritmTest(int a, int b,int c)
        {
            Stopwatch timer = new Stopwatch();
            int actResult = EuclideanAlgoritmClass.Algoritm(timer,a,b,c);
            return actResult;
        }

        [TestCase(1000, 575, 746,345,123, Result = 1)]

        public int EuclideanAlgoritmTest(int a, int b, int c,int d,int e)
        {
            Stopwatch timer = new Stopwatch();
            int actResult = EuclideanAlgoritmClass.Algoritm(timer,a,b,c,d,e);
            return actResult;
        }

    }
}
