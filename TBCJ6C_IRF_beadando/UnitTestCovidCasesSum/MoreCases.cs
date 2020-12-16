using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBCJ6C_IRF_beadando;

namespace UnitTestCovidCasesSum
{
    class MoreCases
    {
        [Test,
            TestCase(15, 30, "<"),
            TestCase(30, 30, "="),
            TestCase(300, 45, ">")
        ]
        public void SumCases(int c1sum, int c2sum, string expectedResult)
        {
            var ccform = new CovidCasesForm();
            var ActualResult = ccform.MoreCases(c1sum, c2sum);

            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}
