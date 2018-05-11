using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> extractedLinks = new List<string>();
        List<string> extractedTitle = new List<string>();
        List<string> extractedContent = new List<string>();

        IWebDriver driver = new PhantomJSDriver();
        IWebElement titleElement;
        IWebElement contentElement;

        string[] pageSource;

        string sitemapURL = "http://testing.todvachev.com/sitemap-posttype-post.xml";
        string titleSelector = "#main-content > article > header > h1";
        string contentSelector = "#main-content > article > div";

        int startIndex = 0;
        int linkLength = 0;

        driver.Navigate().GoToUrl(sitemapURL);

        pageSource = driver.PageSource.Split(' ');

        foreach(var item in pageSource)
        {
            if (item.Contains("<loc>"))
            {
                startIndex = item.IndexOf("<loc>") + 5;
                linkLength = item.IndexOf("</loc>") - startIndex;


                //extractedLinks.Add(item.Substring(item.IndexOf("<loc>")));
                extractedLinks.Add(item.Substring(startIndex, linkLength));
                Console.WriteLine(item.Substring(startIndex, linkLength));

                //Console.WriteLine(item.Substring(item.IndexOf("<loc>")));
            }
        }

        foreach (var item in extractedLinks)
        {
            driver.Navigate().GoToUrl(item);

            titleElement = driver.FindElement(By.CssSelector(titleSelector));
            contentElement = driver.FindElement(By.CssSelector(contentSelector));


            extractedTitle.Add(titleElement.Text);
            extractedContent.Add(contentElement.Text);

            //Despliega todo el valor del contenido del sitio
            /*Console.WriteLine(titleElement.Text);
            Console.WriteLine(contentElement.Text);*/
        }

        Directory.CreateDirectory(@"\ExtractedContent");

        using (StreamWriter sw = File.CreateText(Directory.GetCurrentDirectory() + @"\ExtractedContent\ExtractedTest.txt"))
        {
            sw.WriteLine("TITLE: {0}",extractedTitle[0]);
            sw.WriteLine("CONTENT:");
            sw.Write(extractedContent[0]);
        }

        //Console.WriteLine(driver.PageSource);
    }
}