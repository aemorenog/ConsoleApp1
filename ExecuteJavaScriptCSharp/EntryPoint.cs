using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        string url = "http://testing.todvachev.com/";

        driver.Navigate().GoToUrl(url);

        //Texto del sitio
        IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div"));

        //Imagen del sitio
        //IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));



        //Desaparece imagen
        //string script = "arguments[0].style[\"display\"]=\"none\"";

        //Cambia de color el texto del sitio
        //string script = "arguments[0].style[\"color\"] = \"green\"";

        //Cambia el color del borde y lo deja con grosor
        //string script = "arguments[0].style[\"border\"] = \"2px solid green\"";

        SetStyle(driver, content, "color", "yellow");

    }


    static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
    {
        string script = string.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

        jsExecutor.ExecuteScript(script, element);
    }
}
