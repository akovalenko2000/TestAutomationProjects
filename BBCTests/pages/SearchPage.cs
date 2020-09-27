using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
namespace BBCTests.pages
{
    class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//body/div/div/main/div[3]/div/div/ul/li[1]/div/div[1]/div[1]/p[1]/a")]
        [CacheLookup]
        private IWebElement searched_title;
        public SearchPage(IWebDriver driver) : base(driver) { }
        public void GetSearchedTitle()
        {
            searched_title.Click();
        }
    }
}
