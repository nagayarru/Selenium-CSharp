using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;




namespace SeleniumConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver x = new ChromeDriver();
            x.Navigate().GoToUrl("http://www.bing.com");
            x.Quit();
        }
    }
}
