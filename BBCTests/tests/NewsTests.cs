using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BBCTests.tests;
using SeleniumExtras.PageObjects;

namespace BBCTests.tests
{       
    class NewsTests
    {   [FindsBy(How = How.XPath, Using = "//h1[@class = 'story-body__h1']")]

        private IWebElement Head_title;
        

        [TestMethod]
        public void CheckHeadlineArticleTitle()
        {
            string headTitle = "Portland suspect shot dead by police during arrest";
             GetNewsPage().SearchByKeyWord(headTitle);
            Assert.AreEqual(headTitle, Head_title.Text);
        }

        [TestMethod]
        public void CheckSecondaryArticleTitle()
        {
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

        [TestMethod]
        public void CheckCategoryheadlineArticleTitle()
        {
            string searched_title = "The buildings heated by human warmth";
            GetNewsPage().SearchByKeyWord(searched_title);
            Assert.AreEqual(searched_title, GetSearchPage().GetSearchedTitle().Text);

        }
    }
}
