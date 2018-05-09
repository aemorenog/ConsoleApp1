using OpenQA.Selenium;
using NUnit.Framework;

namespace _11.AutoTestFramework.Scenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidUsername()
        {

        }
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormSecenarioThroughtTestCases(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            NavigateTo.LoginFormThroughtTheMenu(Driver);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, 
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.UsernameLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsMessages.UsernameLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }


    }
}
