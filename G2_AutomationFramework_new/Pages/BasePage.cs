using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace G2_AutomationFramework_new.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)

        {
            PageFactory.InitElements(driver, this);
        }
    }
}
