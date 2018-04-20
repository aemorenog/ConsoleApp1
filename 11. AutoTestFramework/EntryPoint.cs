namespace _11.AutoTestFramework
{
    class EntryPoint
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            menu.Selectors.Click();
        }
    }
}
