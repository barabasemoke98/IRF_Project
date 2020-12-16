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
        [Test]
        public void SumCases(int c1sum, int c2sum, string expectedResult)
        {
            var ccform = new CovidCasesForm();
            var ActualResult = ccform.MoreCases(c1sum, c2sum);

            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}
