using EtsyAutomationTests_new.Pages;
using G2_AutomationFramework_new.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EtsyAutomationTests_new.Tests
{
    public class EtsyTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestSearch()
        {
            var searchText = "Men`s Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchField.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();

            EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

            //*[contains(@class,'v2-listing-card__info')and not(contains(@class, 'flex'))]
        }
    }
}
