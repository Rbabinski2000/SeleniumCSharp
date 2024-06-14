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


            BaseTest.CloseCookies(driver);

            string temp= emailTextField.GetAttribute("value");
           
        }

        [Test, Category("Regression testing")]
        public void TestMethod2()
        {

            BaseTest.CloseCookies(driver);

            IWebElement CreateAccountButton = driver.FindElement(By.XPath(".//*[starts-with(@id, 'u_0_0_') and string-length(@id) >= 7]"));
            CreateAccountButton.Click();

            BaseTest.CloseCookies(driver);
            
            IWebElement MonthList = driver.FindElement(By.XPath(".//*[@id=\'month\']"));
            SelectElement Months = new SelectElement(MonthList);
            Months.SelectByValue("1");


            //string temp= emailTextField.Text;
            //Assert.AreEqual(textTest, temp);
        }


    }
}