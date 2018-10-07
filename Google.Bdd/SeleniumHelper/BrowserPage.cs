using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Google.Bdd.SeleniumHelper
{
    public class BrowserPage
    {
        public static IWebDriver driver;
        
        public static void InstantiateDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public static void Close()
        {
            driver.Quit();
        }

        public static void GotoUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
