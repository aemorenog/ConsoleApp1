using System.Threading;

namespace _11.AutoTestFramework
{
    class EntryPoint
    {
        static void Main()
        {


            NavigateTo.LoginFormThroughtTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            /*Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughtTheMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(500);

            Driver.driver.Quit();*/
        }
    }
}
