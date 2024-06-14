using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumCSharpTests.BaseClass;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumCSharpTests.Utilities;

//[assembly: LevelOfParallelism(10)]
namespace SeleniumCSharpTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod1()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver=utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            BrowserUtility utils = new BrowserUtility();
            var Driver = utils.Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);

            Driver.Quit();

        }
    }
}
