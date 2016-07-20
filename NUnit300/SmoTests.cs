using System;
using Microsoft.SqlServer.Management.Smo;

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
            var server = new Server(String.Empty);
            server.ConnectionContext.ExecuteNonQuery(String.Empty);
            Console.WriteLine("Успех - моё второе имя");
            Assert.True(true);
        }

    }
}
