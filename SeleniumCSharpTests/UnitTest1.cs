using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTests.BaseClass;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpTests
{
    [TestFixture]
    public class TestClass:BaseTest
    {
        [Test,Category("Smoke testing")]
        public void TestMethod1()
        {
            
            IWebElement emailTextField=driver.FindElement(By.XPath(".//*[@id=\'email\']"));
            string textTest = "Selenium C#";
            emailTextField.SendKeys(textTest);


            IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']"));
            cokkies.Click();

            string temp= emailTextField.GetAttribute("value");
            Assert.AreEqual(textTest, temp);
        }

        [Test, Category("Regression testing")]
        public void TestMethod2()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']"))).Click();

            //IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']"));
            //cokkies.Click();
            
            IWebElement CreateAccountButton = driver.FindElement(By.XPath(".//*[starts-with(@id, 'u_0_0_') and string-length(@id) >= 7]"));
            CreateAccountButton.Click();

            try
            {
                IWebElement cookiesButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']")));
                cookiesButton2.Click();
            }
            catch (WebDriverTimeoutException)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("console.log('Cookies2 button not found or not clickable within the timeout period.')");
            }
            
            IWebElement MonthList = driver.FindElement(By.XPath(".//*[@id=\'month\']"));
            SelectElement Months = new SelectElement(MonthList);
            Months.SelectByValue("1");


            //string temp= emailTextField.Text;
            //Assert.AreEqual(textTest, temp);
        }


    }
}