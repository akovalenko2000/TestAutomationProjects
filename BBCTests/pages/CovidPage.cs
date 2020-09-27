using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;

namespace BBCTests.pages
{
    class CovidPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,' gel')]//a[@href='/news/have_your_say']")]
        [CacheLookup]
        private IWebElement have_your_say;
        public void ClickHaveYourSay()
        {
            have_your_say.Click();
        }
        public CovidPage(IWebDriver driver) : base(driver) { }
    }
}
