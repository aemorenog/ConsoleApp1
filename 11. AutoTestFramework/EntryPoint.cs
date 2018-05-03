using NUnit.Framework;
using OpenQA.Selenium;

namespace _11.AutoTestFramework
{
    class EntryPoint
    {


        static void Main()
        {
            /*Menu menu = new Menu();

            NavigateTo.LoginFormThroughtTheMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(500);

            Driver.driver.Quit();**/

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            NavigateTo.LoginFormThroughtTheMenu();
            Actions.FillLoginForm(Config.)
        }
    }
}
