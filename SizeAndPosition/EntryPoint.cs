using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

class EntryPoint
{
    static void Main(string[] args)
    {
        Size size = new Size();

        size.Width = 600;
        size.Height = 600;

        Point position = new Point();
        position.X = 500;
        position.Y = 500;

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com");
        driver.Manage().Window.Size = size;
        driver.Manage().Window.Position = position;

        //Posision definida del browser
        //driver.Manage().Window.Position = new Point(0,0);

        //Tamaño defenido del tamaño del browser
        //driver.Manage().Window.Size = new Size(600, 600);

    }
}

