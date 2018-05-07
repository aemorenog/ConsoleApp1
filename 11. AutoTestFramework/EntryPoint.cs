using NUnit.Framework;
using OpenQA.Selenium;

namespace _11.AutoTestFramework
{
    class EntryPoint
    {

        //IAlert alert;

        static void Main()
        {
            /*Menu menu = new Menu();

            NavigateTo.LoginFormThroughtTheMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(500);

            Driver.driver.Quit();**/

            //Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            /*NavigateTo.LoginFormThroughtTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassowrd);*/
        }

        /*[SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughtTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassowrd);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.SuccessfullLogin, alert.Text);

            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }*/
    }
}
