using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTests.pages
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='media__link'][@href = '/news/world-us-canada-54023227']")]
        [CacheLookup]
        private IWebElement headtitle;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb - nav - links']/ul/li[2]/a")]
        [CacheLookup]
        private IWebElement list_of_news;

        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/news/uk-54093465']")]
        [CacheLookup]
        private IWebElement title1;
        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/news/technology-54086598']")]
        [CacheLookup]
        private IWebElement title2;
        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/travel/bespoke/untold-america/new-york/']")]
        [CacheLookup]
        private IWebElement title3;
        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.bbc.com/future/article/20200908-the-buildings-warmed-by-the-human-body']")]
        [CacheLookup]
        private IWebElement title4;

        public void ClickHeadTitle()
        {
            headtitle.Click();
        }
        public void ClickOnNewsList()
        {
            list_of_news.Click();
        }
        public void ClickTitle1()
        {
            title1.Click();
        }
        public void ClickTitle2()
        {
            title2.Click();
        }
        public void ClickTitle3()
        {
            title3.Click();
        }
        public void ClickTitle4()
        {
            title4.Click();
        }
        public HomePage(IWebDriver driver):base(driver) { }
    }
}
