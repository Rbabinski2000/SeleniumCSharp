using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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
        [TearDown]
        public void Close()
        {
            //driver.Close();
            driver.Quit();
        }
        public static string GetFirefoxLocation()
        {
            var options = new FirefoxOptions()
            {
                BrowserVersion = "stable"
            };
            return new DriverFinder(options).GetBrowserPath();
        }
        public static void JebacCookies(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            try
            {
                IWebElement cookiesButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@aria-label='Odrzuć opcjonalne pliki cookie']")));
                cookiesButton2.Click();
            }
            catch (WebDriverTimeoutException)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("console.log('Cookies2 button not found or not clickable within the timeout period.')");
            }
        }
    }
}
