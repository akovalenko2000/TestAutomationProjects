using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BBCTests.pages;

namespace BBCTests.tests
{
    class BaseTests
    {
        private IWebDriver driver;
        private static string BBC_URL = "https://www.bbc.com/";
        
        [SetUp]
        public void BeforeTests()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(BBC_URL);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterTests()
        {
            driver.Close();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public BasePage GetBasePage()
        {
            return new BasePage(GetDriver());
        }
        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }
        public HaveYourSayPage GetHaveYourSayPage()
        {
            return new HaveYourSayPage(GetDriver());
        }
        public NewsPage GetNewsPage()
        {
            return new NewsPage(GetDriver());
        }
        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
        }
        public CovidPage GetCovidPage()
        {
            return new CovidPage(GetDriver());
        }

        internal class NewsPage
        {
            public NewsPage()
            {
            }

            internal object GetCovidPage()
            {
                throw new NotImplementedException();
            }
        }
    }
}
