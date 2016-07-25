using System;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using NUnit.Framework;

namespace NUnit2bBD
{
    public class DBSimpleTest
    {
        [Test]
        public void GetVersionTest()
        {
            String sqlServerLogin = "jetbrains";
            String password = "jetbrains";
            String instanceName = "";
            String remoteSvrName = "tcqa-mssql-2014.labs.intellij.net";

            ServerConnection srvConn = new ServerConnection();
            srvConn.ServerInstance = remoteSvrName + "\\" + instanceName;
            srvConn.LoginSecure = false;
            srvConn.Login = sqlServerLogin;
            srvConn.Password = password;
            Server srv = new Server(srvConn);

            Console.WriteLine(srv.Information.Version);

            Assert.AreEqual("12.0.4100", srv.Information.Version.ToString());
        }
    }
}
