using NUnit.Framework;
using calc;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        [OneTimeSetUp]
        public void Setup()
        {
            TestContext.Out.WriteLine("Start");
        }

        [Test]
        public void Test1([Values(16)] int x, [Values(32)]int y, [Values(48)] int ExpectedResult)
        {
            Calc c = new Calc();
            Assert.AreEqual(c.Sum(x, y), ExpectedResult);
        }
        //[TestCase(9, 8, ExpectedResult = 72)]
        [Test]
        public void Test2([Values(9)] int x, [Values(8)] int y,[Values(72)] int ExpectedResult)
        {

            Calc c = new Calc();
            Assert.AreEqual(c.Mul(x,y), ExpectedResult);
        }
        //DataProvider
        private static readonly object[] vs =
        {
            new object[] {9, 81}
        };
        [Test,TestCaseSource(nameof(vs))]
        public void Test3(int x, int ExpectedResult)
        {
            Calc c = new Calc();
            int Actual = c.square(x);
            Assert.AreEqual(Actual, ExpectedResult);
            //return Actual;
        }
        //[Test]
        [TestCase(9, 3)]
        public void Test4(int x, int ExpectedResult)
        {

            Calc c = new Calc();
            Assert.AreEqual(c.Root(x), ExpectedResult);
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            TestContext.Out.WriteLine("End");
        }
    }
}