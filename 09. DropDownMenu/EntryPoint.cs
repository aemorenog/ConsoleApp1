using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropMenu;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
        
        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        elementFromTheDropMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine("The Third option from the drop down menu is: "+ elementFromTheDropMenu.GetAttribute("value"));

        elementFromTheDropMenu.Click();

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(3000);

        for (int i =1; i < 5; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";
            elementFromTheDropMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The "+ i + " option from the dropdown menu is: " + elementFromTheDropMenu.GetAttribute("value"));

        }

        Thread.Sleep(3000);
    }
}
