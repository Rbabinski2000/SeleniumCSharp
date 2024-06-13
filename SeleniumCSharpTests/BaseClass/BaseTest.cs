using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTests.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open() 
        {
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--disable-notifications");
            //chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            
        }
        //[TearDown]
        public void Close()
        {
            //driver.Close();
            driver.Quit();
        }
    }
}
