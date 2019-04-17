﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EtsyAutomationTests_new.Pages
{
    class SearchArea
    {
        public SearchArea(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "search-query")]
        public IWebElement searchField;

        [FindsBy(How = How.CssSelector, Using = "button[value=Search]")]
        public IWebElement searchButton;

    }
}
