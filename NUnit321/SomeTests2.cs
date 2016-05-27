using System;

namespace NUnit321
{
    using NUnit.Framework;

    [TestFixture]
    public class SomeTests2
    {
        [OneTimeSetUp]
        public void Init()
        {
            Console.WriteLine("OneTimeSetup method!!!!");
        }

        [Test]
        [Repeat(5)]
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
        [Repeat(7)]
        [Category("calc")]
        public void TestMultiply()
        {
            Assert.That(1 * 3, Is.EqualTo(3), "123456");
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
