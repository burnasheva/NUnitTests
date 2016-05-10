using System;
using System.Diagnostics.CodeAnalysis;

namespace NUnit301
{
    using NUnit.Framework;

    [TestFixture]
    public class SomeTests
    {
        [Test]
        [Category("calc"), Category("smth")]
        public void TestPlus()
        {
            Assert.That(1 + 3, Is.EqualTo(4));
        }

        [Test]
        public void showInfo()
        {
            Console.WriteLine($"CurrentDirectory={Environment.CurrentDirectory}");
            Console.WriteLine($"Bitness={IntPtr.Size * 8}");
            Console.WriteLine($"ConfigurationFile={AppDomain.CurrentDomain.SetupInformation.ConfigurationFile}");
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
        [ExcludeFromCodeCoverage]
        public void TestSmth()
        {
        }
    }
}
