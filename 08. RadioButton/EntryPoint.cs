using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

class EntryPoint
{
    static IWebDriver driver = new FirefoxDriver();
    static IWebElement radioButton;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string[] option = {"1","3","5"};

        driver.Navigate().GoToUrl(url);

        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector(".entry-content > form:nth-child(2) > p:nth-child(6) > input:nth-child(" + option + ")"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The" + i + "radio button is checked!");
            }
            else
            {
                Console.WriteLine("This is one of the unchecked radio buttons");
            }
        }
        ///driver.Quit();
    }
}