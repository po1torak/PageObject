using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.PageObjects
{
    class GoogleSearchPage
    {
        private IWebDriver driver;

        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement searchLine;

        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searchButton;

        [FindsBy(How = How.Name, Using = "btnI")]
        private IWebElement luckyButton;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://google.com");
        }

        public void enterTextToSearchLine(string text)
        {
            searchLine.Click();
            searchLine.SendKeys(text);
        }

        public void clickOnSearchButton()
        {
            searchButton.Click();
        }

        public void clickOnLuckyButton()
        {
            luckyButton.Click();
        }

        public void clickOnEnter()
        {
            searchButton.SendKeys(Keys.Enter);
        }




    }
}
