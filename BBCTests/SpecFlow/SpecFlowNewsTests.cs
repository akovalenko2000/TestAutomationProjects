using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BBCTests.SpecFlow
{
    [Binding]
    public sealed class SpecFlowNewsTests
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        IWebDriver driver = new ChromeDriver();
        public SpecFlowNewsTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(" User on main page")]
        public void MainPage()
        {

            driver.Navigate().GoToUrl("https://www.bbc.com");
            _scenarioContext.Pending();
        }


        [When("I go to news page")]
        public void NewsPage()
        {
            //TODO: implement act (action) logic
            driver.FindElement(By.XPath("//a[@class='media__link'][@href = '/news']")).Click();
            _scenarioContext.Pending();
        }

        [When("I go to search page")]
        public void SearchPage()
        {
            driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys("title");
            driver.FindElement(By.XPath("//button[@id= 'orb-search-button']")).Click();
            _scenarioContext.Pending();
        }
        [When(@"Enter the search title")]
        public void EnterTitle()
        {
            driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys("Portland suspect shot dead by police during arrest");
            driver.FindElement(By.XPath("//button[@id= 'orb-search-button']")).Click();
            _scenarioContext.Pending();
        }

        [Then("I read the head title")]
        public void ReadHeadTitle()
        {
            var element = driver.FindElement(By.XPath("//h1[@class = 'story-body__h1']"));
            Assert.AreEqual("Portland suspect shot dead by police during arrest", element.Text);

        }

        [Then("I read the four second (.*)")]

        public void ReadSecondaryTitles( string title)
        {
            driver.FindElement(By.XPath("//*[@id='orb - nav - links']/ul/li[2]/a")).Click();

            new GetNewsPage().ClickOnNewsList();
            string news_title1 = "New UK virus measures 'not a second lockdown' says PM";
            string news_title2 = "New York’s last great jazz parlour";
            string news_title3 = "Facebook 'profits from hate' claims engineer who quit";
            string news_title4 = "The buildings heated by human warmth";

            List<String> ExpRes = new List<String>();
            ExpRes.Add(news_title1);
            ExpRes.Add(news_title2);
            ExpRes.Add(news_title3);
            ExpRes.Add(news_title4);

            Assert.AreEqual(news_title1, GetNewsPage().ClickTitle1().Text);
            Assert.AreEqual(news_title2, GetNewsPage().ClickTitle2().Text);
            Assert.AreEqual(news_title3, GetNewsPage().ClickTitle3().Text);
            Assert.AreEqual(news_title4, GetNewsPage().ClickTitle4().Text);
        }
    }
}
