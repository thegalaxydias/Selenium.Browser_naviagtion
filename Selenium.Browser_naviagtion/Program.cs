using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium.Browser_naviagtion
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://itechcraft.com/");
            driver.Navigate().GoToUrl("https://itechcraft.com/about-it-craft/");
            driver.Navigate().Back();
            driver.Close();
        }
    }
}
