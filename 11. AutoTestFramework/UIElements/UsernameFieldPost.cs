using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace _11.AutoTestFramework.UIElements
{
    class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }


    }
}
