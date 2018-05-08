using NUnit.Framework;
using OpenQA.Selenium;

namespace _11.AutoTestFramework.Scenarios
{
    [Parallelizable(ParallelScope.None)]
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {

        }

        [SetUp]
        public void initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormSecenarioThroughtTestCases();
        }

        [Test]
        public void LessThan4Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit(); 
        }

    }
}
