using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
//using SeleniumExtras.PageObjects;
using System.Threading;
namespace BBCTests
{
    [TestClass]
    public class UnitTestPartOne
    {
        [TestMethod]
        public void CheckHeadlineArticleTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            
            driver.FindElement(By.XPath("//a[@class='media__link'][@href = '/news/world-us-canada-54023227']")).Click();
            var element = driver.FindElement(By.XPath("//h1[@class = 'story-body__h1']"));
            Assert.AreEqual("Portland suspect shot dead by police during arrest", element.Text);
        }

        [TestMethod]
        public void CheckSecondaryArticleTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//*[@id='orb - nav - links']/ul/li[2]/a")).Click();

            List<String> ExpRes = new List<String>();
            ExpRes.Add("New UK virus measures 'not a second lockdown' says PM");
            ExpRes.Add("New York’s last great jazz parlour");
            ExpRes.Add("Facebook 'profits from hate' claims engineer who quit");
            ExpRes.Add("The buildings heated by human warmth");

            var element = driver.FindElement(By.XPath("//a[@href = 'https://www.bbc.com/news/uk-54093465']"));
            Assert.AreEqual("New UK virus measures 'not a second lockdown' says PM", element.Text);
            element = driver.FindElement(By.XPath("//a[@href = 'https://www.bbc.com/news/technology-54086598']"));
            Assert.AreEqual("Facebook 'profits from hate' claims ex-engineer", element.Text);
            element = driver.FindElement(By.XPath("//a[@href = 'https://www.bbc.com/travel/bespoke/untold-america/new-york/']"));
            Assert.AreEqual("New York’s last great jazz parlour", element.Text);
            element = driver.FindElement(By.XPath("//a[@href = 'https://www.bbc.com/future/article/20200908-the-buildings-warmed-by-the-human-body']"));
            Assert.AreEqual("The buildings warmed by the human body", element.Text);

        }
 
        [TestMethod]
        public void CheckCategoryHeadlineArticleTitle()
        {
            string news_title = "The buildings heated by human warmth";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//a[@href= 'https://www.bbc.com/news']")).Click();
            driver.FindElement(By.XPath("//input[@id='orb-search-q']")).SendKeys(news_title);
            driver.FindElement(By.XPath("//button[@id= 'orb-search-button']")).Click();
            var element = driver.FindElement(By.XPath("//body/div/div/main/div[3]/div/div/ul/li[1]/div/div[1]/div[1]/p[1]/a"));
            Assert.AreEqual(news_title, element.Text);
           
        }
    }

    [TestClass]
    public class UnitTestPartTwo
    {
        [TestMethod]
        public void FillFormWithoutCheckbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//a[@href= 'https://www.bbc.com/news']")).Click();
            driver.FindElement(By.XPath("//li[contains(@class,'gel')]//a[@href=' /news/coronavirus']")).Click();
            driver.FindElement(By.XPath("//li[contains(@class,' gel')]//a[@href='/news/have_your_say']")).Click();
            driver.FindElement(By.XPath("//div[contains(@class,'long')]")).SendKeys("My Lorem Ipsum");
            driver.FindElement(By.XPath("//div[contains(@class,'threeup-leading')]")).SendKeys("NAME");
            driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
            var element = driver.FindElement(By.XPath("//div[@class='checkbox']//div[contains(@class,'error-')]"));
            Assert.AreEqual("must be accepted", element.Text);
        }
        [TestMethod]
        public void FillFormWithoutName()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//a[@href= 'https://www.bbc.com/news']")).Click();

            driver.FindElement(By.XPath("//li[contains(@class,'gel')]//a[@href=' /news/coronavirus']")).Click();
            driver.FindElement(By.XPath("//li[contains(@class,' gel')]//a[@href='/news/have_your_say']")).Click();
            driver.FindElement(By.XPath("//div[contains(@class,'checkbox')]//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//div[contains(@class,'long')]")).SendKeys("My Lorem Ipsum");
            driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
            var element = driver.FindElement(By.XPath("//div[contains(@class,'long')]//div[contains(@class,'error')]"));
            Assert.AreEqual("can`t be blank", element.Text);

        }
        [TestMethod]
        public void FillFormWithoutText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.FindElement(By.XPath("//a[@href= 'https://www.bbc.com/news']")).Click();

            
            driver.FindElement(By.XPath("//div[contains(@class,'checkbox')]//p[contains(text(),'accept')]")).Click();
            driver.FindElement(By.XPath("//div[contains(@class,'checkbox')]//p[contains(text(),'16 ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
            var element = driver.FindElement(By.XPath("//div[contains(@class,'long')]//div[contains(@class,'error')]"));
            Assert.AreEqual("can`t be blank", element.Text);
        }



    }

}
