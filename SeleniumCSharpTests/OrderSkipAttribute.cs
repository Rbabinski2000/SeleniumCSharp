using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumCSharpTests.BaseClass;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Edge;


namespace SeleniumCSharpTests
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(2),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);


            IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuć opcjonalne pliki cookie']"));
            cokkies.Click();

            driver.Quit();
        }
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);


            IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuć opcjonalne pliki cookie']"));
            cokkies.Click();

            driver.Quit();
        }
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
           
            Assert.Ignore("Testing of Skip Attribute");
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.BinaryLocation = BaseClass.BaseTest.GetFirefoxLocation();
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            var driver = new FirefoxDriver(firefoxOptions);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Url= "https://www.facebook.com/"; 
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);


            //IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuć opcjonalne pliki cookie']"));
            //cokkies.Click();

            driver.Quit();
        }



    }
}
