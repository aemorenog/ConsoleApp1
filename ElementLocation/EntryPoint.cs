using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "http://testing.todvachev.com";

        driver.Navigate().GoToUrl(url);

        IWebElement imagen = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));

        driver.Manage().Window.Maximize();

        Console.WriteLine(imagen.Location.X);
        Console.WriteLine(imagen.Location.Y);
        Console.WriteLine(imagen.Size.Width);
        Console.WriteLine(imagen.Size.Height);

    }
}
