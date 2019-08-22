using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagefactorytest2
{
    class test
    {

        [Test]
        public void nhlMainPageTest()
        {
            PfTest test = new PfTest();
            test.teamsButton.Click();
        }
    }
}
