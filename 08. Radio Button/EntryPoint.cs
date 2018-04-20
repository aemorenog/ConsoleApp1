using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement radioButton;

    static void Main()
    {   

        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string option = "1";

        driver.Navigate().GoToUrl(url);

        radioButton = driver.FindElement(By.CssSelector("# post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(1)"));

        if(radioButton.GetAttribute("checked") == "true")
        {
            Console.WriteLine("This radio button is checked!");
        }
        else
        {
            Console.WriteLine("This is one of unchecked radio button");
        }
    }
}