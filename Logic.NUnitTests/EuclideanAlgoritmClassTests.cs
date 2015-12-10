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

        public int EuclideanAlgoritmTest(int a, int b,int c)
        {

            int actResult = EuclideanAlgoritmClass.Algoritm(EuclideanAlgoritmClass.Algoritm(a, b),c);
            return actResult;
        }


    }
}
