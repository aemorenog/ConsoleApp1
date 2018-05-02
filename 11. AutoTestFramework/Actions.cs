

using _11.AutoTestFramework.UIElements;

namespace _11.AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.Sendkeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}
