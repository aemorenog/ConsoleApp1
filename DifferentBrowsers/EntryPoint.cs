using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new InternetExplorerDriver();

        driver.Navigate().GoToUrl("http://google.com");
    }
}