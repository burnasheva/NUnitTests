﻿namespace NUnit300
{
    using NUnit.Framework;

    [TestFixture]
    public class TwoTests
    {
        [Test]
        [Category("calc"), Category("smth")]
        public void TestPlus()
        {
            Assert.That(1 + 6, Is.EqualTo(7));
        }

        [Test]
        [Category("calc")]
        public void TestMinus()
        {
            Assert.That(1 - 3, Is.EqualTo(-2));
        }

        [Test]
        [Category("calc")]
        public void TestMultiply()
        {
            Assert.That(1 * 3, Is.EqualTo(3));
        }

        [Test]
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
