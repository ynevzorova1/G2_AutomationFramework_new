using G2_AutomationFramework_new.Pages;
using OpenQA.Selenium;

namespace EtsyAutomationTests_new.Pages
{
    class EtsyMainPage : BasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;
    }
}
