using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCTests.BBL
{
    class BLL
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public BLL(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        string text = "bla-bla-bla";
        string name = "Name";
        string checkbox_error = "must be accepted";
        string textfield_error = "can`t be blank";




        [FindsBy(How = How.XPath, Using = "//div[@class='checkbox']//div[contains(@class,'error-')]")]
        [CacheLookup]
        private IWebElement checkbox_error_message;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'long')]//div[contains(@class,'error')]")]
        [CacheLookup]
        private IWebElement textfield_error_message;
        public void FillFormWithoutCheckbox()
        {
            new BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().EnterText(text).EnterName(name).ClickSubmit();
            Assert.AreEqual(checkbox_error, checkbox_error_message.Text);
        }

        public void FillFormWithoutName()
        {
            BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().ClickAccept().ClickAge().ClickSubmit();
            Assert.AreEqual(textfield_error, textfield_error_message.Text);

        }
        public void FillFormWithoutText()
        {
            BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().EnterText(text).ClickAccept().ClickAge().ClickSubmit();
            Assert.AreEqual(textfield_error, textfield_error_message.Text);
        }

    }
}
