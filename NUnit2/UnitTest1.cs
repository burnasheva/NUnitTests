using System;
using Microsoft.SqlServer.Management.Smo;
using Calculator = Calculator.Calculator;

namespace NUnit2
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTest1
    {
        private ServerStatus _serverStatus;

        [Test]
        public void TestCalculator()
        {
            global::Calculator.Calculator calc = new global::Calculator.Calculator();
            Assert.AreEqual(9.9, calc.summ(4.5, 4.4));
        }

        [Test]
        public void TestLoadDll()
        {
            CalcProject.Calculator.plus(2.4, 4.5);
            _serverStatus = ServerStatus.Offline;
        }

        [Test]
        [Category("calc"), Category("smth")]
        public void TestPlus()
        {
            Console.WriteLine("http://user:123456@jetbrains.com");
            Console.WriteLine("123456");
            Assert.That(1 + 3, Is.EqualTo(5), "123456 password");
        }


        [Test]
        [Category("calc")]
        public void TestMinus()
        {
            Assert.That(1 - 3, Is.EqualTo(-3), "http://user:123456@jetbrains.com");
        }

        [Test]
        [Category("calc")]
        public void TestMultiply()
        {
            Assert.That(1 * 3, Is.EqualTo(2), "123456");
        }

        [Test]
        [Ignore("http://user:123456@jetbrains.com")]
        [Category("calc")]
        public void TestDivizion()
        {
            Assert.That(3 / 3, Is.EqualTo(1));
        }

        [Test]
        [Category("smth")]
        public void TestSmth()
        {
        }
    }
}
