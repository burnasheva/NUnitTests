using System;
using CalcProject;
using Microsoft.SqlServer.Management.Smo;

namespace NUnit300
{
    using NUnit.Framework;
    
    [TestFixture]
    public class SmoTests
    {
        [Test]
        public void TestLoadDll()
        {
            Calculator.plus(2.4, 4.4);
        }

        [Test]
        [Category("calc"), Category("smth")]
        public void TestPlus()
        {
           
                var server = new Server(String.Empty);
                server.ConnectionContext.ExecuteNonQuery(String.Empty);
                Console.WriteLine("Успех - моё второе имя");
            Assert.True(true);
        }

    }
}
