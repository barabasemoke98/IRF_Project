using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBCJ6C_IRF_beadando.Entities;

namespace UnitTestCovidCasesSum
{
    public class LoginCheck
    {
        [Test,
            TestCase("Alec98", "3650", false),
            TestCase("Chester37", "4474", true),
            TestCase("Zane17", "718011111", true)
        ]

        public void TestLogin(string username, string password, bool permission)
        {
            var loginform = new Login();

            var actualResult = loginform.userData(username, password);

            Assert.AreEqual(username, actualResult.userName);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreEqual(permission, actualResult.Permission);
        }
    }
}
