using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
namespace BBCTests.pages
{
    class HaveYourSayPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'long')]")]
        [CacheLookup]
        private IWebElement text_field;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'threeup-leading')]")]
        [CacheLookup]
        private IWebElement name_field;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'checkbox')]//p[contains(text(),'16 ')]")]
        [CacheLookup]
        private IWebElement age;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'checkbox')]//p[contains(text(),'accept')]")]
        [CacheLookup]
        private IWebElement accept;
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        [CacheLookup]
        private IWebElement submit_button;
        public void EnterText(string text)
        {
            text_field.SendKeys(text);
        }
        public void EnterName(string name)
        {
            name_field.SendKeys(name);
        }
        public void ClickAccept()
        {
            accept.Click();
        }
        public void ClickAge()
        {
            age.Click();
        }
        public void ClickSubmit()
        {
            submit_button.Click();
        }
        public HaveYourSayPage(IWebDriver driver) : base(driver) { }
        
    }
}
