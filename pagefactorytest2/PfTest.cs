using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagefactorytest2
{
    class PfTest
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = ("//a[text()='Teams'"))]
        public IWebElement teamsButton;

        public PfTest()
        {
            Iniatialize();
        }
        public void Iniatialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://nhl.com");


            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);

        }

        ~PfTest()
        {
            driver.Quit();
        }


    }
}
