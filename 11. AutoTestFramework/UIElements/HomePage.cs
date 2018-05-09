using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace _11.AutoTestFramework
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
