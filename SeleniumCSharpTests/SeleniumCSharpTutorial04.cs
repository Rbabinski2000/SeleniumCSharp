using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTests.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeleniumCSharpTests
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Radek")]
        [Description("Facebook email insertion")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String siteUrl)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = siteUrl;

            //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            //string textTest = "Selenium C#";
            //emailTextField.SendKeys(textTest);

            BaseTest.CloseCookies(driver);

            driver.Quit();
        }

        static IList DataDrivenTesting()
        {
            ArrayList list=new ArrayList();

            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");


            return list;
        }
        [Test]
        [Author("Radek")]
        [Description("Facebook email insertion")]
        
        public void Test2()
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";

                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'email\']"));
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\'abcd\']"));
                string textTest = "Selenium C#";
                emailTextField.SendKeys(textTest);

                BaseTest.CloseCookies(driver);
                
            }
            catch (Exception)
            {
                ITakesScreenshot ts=driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("..\\..\\..\\ScreenShots\\s1.jpeg");
                Console.WriteLine("Upss");
                throw;

            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
            

            
        }
    }
}
