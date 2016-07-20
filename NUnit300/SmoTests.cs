using System;
using CalcProject;

namespace NUnit300
{
    using NUnit.Framework;
    
    [TestFixture]
    public class SmoTests
    {
        [Test]
        [Category("calc"), Category("smth")]
        public void TestPlus()
        {  
            Assert.NotNull(Calculator.plus(3, 3));
        }

    }
}
