using System;

namespace NUnit320
{
    using NUnit.Framework;

    [TestFixture]
    public class SomeTests
    {
        [Test]
        [Category("calc"), Category("smth")]
        [Order(5)]
        public void TestPlus()
        {
            Assert.That(1 + 3, Is.EqualTo(4));
        }

        [Test]
        [Category("calc")]
        [Order(4)]
        public void TestMinus()
        {
            Assert.That(1 - 3, Is.EqualTo(-2));
        }

        [Test]
        [Category("calc")]
        [Order(3)]
        public void TestMultiply()
        {
            Assert.That(1 * 3, Is.EqualTo(3));
        }

        [Test]
        [Category("calc")]
        [Order(2)]
        public void TestDivizion()
        {
            Assert.That(3 / 3, Is.EqualTo(1));
        }

        [Test]
        [Category("smth")]
        [Order(1)]
        public void TestSmth()
        {
            Console.WriteLine("http://user:123456@jetbrains.com");
        }
    }
}
