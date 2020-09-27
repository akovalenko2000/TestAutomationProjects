using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumExtras.PageObjects;
using BBCTests.pages;
using BBCTests.tests;

namespace BBCTests.tests
{
    class FormTest
    {
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
        [TestMethod]
        public void FillFormWithoutCheckbox()
        {
           new BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().EnterText(text).EnterName(name).ClickSubmit();
            Assert.AreEqual(checkbox_error, checkbox_error_message.Text);
        }


        [TestMethod]
        public void FillFormWithoutName()
        {
            BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().ClickAccept().ClickAge().ClickSubmit();
            Assert.AreEqual(textfield_error, textfield_error_message.Text);

        }
        [TestMethod]
        public void FillFormWithoutText()
        {
            BaseTests.NewsPage().GetCovidPage().GetHaveYourSayPage().EnterText(name).ClickAccept().ClickAge().ClickSubmit();
            Assert.AreEqual(textfield_error, textfield_error_message.Text);
        }
    }
}
