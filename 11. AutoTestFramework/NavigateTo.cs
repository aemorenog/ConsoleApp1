
namespace _11.AutoTestFramework
{
    using _11.AutoTestFramework.UIElements;
    using System.Threading;
    using OpenQA.Selenium;

    public static class NavigateTo
    {
        public static void LoginFormSecenarioThroughtTestCases(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameCasePost ucPost = new UsernameCasePost(driver);

            menu.TestCases.Click();
            tcPage.UsernameCase.Click();
            ucPost.LoginFormLink.Click();
        }


       public static void LoginFormThroughtTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);

            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);


        }

        public static void LoginFormThroughThePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameFieldPost ufPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameCase.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }
    }
}
