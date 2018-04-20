using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todorvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathelement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathelement = driver.FindElement(By.XPath(xPath));

        if (cssPathelement.Displayed)
        {
            GreenMessage("I can see the CSS Path Element!");
        }
        else
        {
            RedMessage("I can't see the CSS Path Element!");
        }

        if (xPathelement.Displayed)
        {
            GreenMessage("I can see the xPath Element!");
        }
        else
        {
            RedMessage("I can't see the xPath Element!");
        }


    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

}