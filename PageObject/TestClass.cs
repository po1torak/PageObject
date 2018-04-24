using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void GoogleSearch()
        {
            GoogleSearchPage homePage = new GoogleSearchPage(driver);
            homePage.goToPage();
            string textToSearch = "Wikipedia";
            homePage.enterTextToSearchLine(textToSearch);
            homePage.clickOnEnter();
            Assert.AreEqual("Wikipedia - Поиск в Google", driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
