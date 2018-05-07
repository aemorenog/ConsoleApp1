﻿using _11.AutoTestFramework.UIElements;
using System.Threading;

namespace _11.AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormSecenarioThroughtTestCases()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ucPost = new UsernameCasePost();

            menu.TestCases.Click();
            tcPage.UsernameCase.Click();
            ucPost.LoginFormLink.Click();
        }


       public static void LoginFormThroughtTheMenu()
        {
            Menu menu = new Menu();

            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);


        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameCase.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }
    }
}
