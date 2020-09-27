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
    public sealed class SpecFlowFormTests
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = new ChromeDriver();
        
        public SpecFlowFormTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

       

        [Given("User is on the main page")]
        public void MainPage()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//a[@href= 'https://www.bbc.com/news']")).Click();
            _scenarioContext.Pending();
        }
        [Given("User goes to covid page")]
        public void CovidPage()
        {
            driver.FindElement(By.XPath("//li[contains(@class,'gel')]//a[@href=' /news/coronavirus']")).Click();
            _scenarioContext.Pending();
        }
        [Given("User clicks have your say")]
        public void HaveYourSayPage()
        {

            driver.FindElement(By.XPath("//li[contains(@class,' gel')]//a[@href='/news/have_your_say']")).Click();
            _scenarioContext.Pending();
        }

        [When("User enters the data")]
        public void EnterData()
        {
            driver.FindElement(By.XPath("//div[contains(@class,'long')]")).SendKeys("My Lorem Ipsum");
            driver.FindElement(By.XPath("//div[contains(@class,'threeup-leading')]")).SendKeys("NAME");
            driver.FindElement(By.XPath("//div[contains(@class,'checkbox')]//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//div[contains(@class,'checkbox')]//p[contains(text(),'16 ')]")).Click();
            

            _scenarioContext.Pending();
        }
        [When("User clicks submit")]
        public void ClickSubmit()
        {
            driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
            _scenarioContext.Pending();
        }

        [Then("Error message is shown")]
        public void ErrorMessage(int result)
        {
            var element = driver.FindElement(By.XPath("//div[contains(@class,'long')]//div[contains(@class,'error')]"));
            Assert.AreEqual("can`t be blank", element.Text);
            element = driver.FindElement(By.XPath("//div[@class='checkbox']//div[contains(@class,'error-')]"));
            Assert.AreEqual("must be accepted", element.Text);

            _scenarioContext.Pending();
        }
    }
}
