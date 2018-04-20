using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;
    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "1";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        checkBox.Click();

        Thread.Sleep(5000);
        /*Console.WriteLine(checkBox.GetAttribute("value"));

        option = "3";

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        Console.WriteLine(checkBox.GetAttribute("value"));*/

        /*if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("The checkbox is checked!");
        }
        else
        {
            Console.WriteLine("The checkbox is NOT checked!");
        }*/


        ///driver.Quit();
    }
}