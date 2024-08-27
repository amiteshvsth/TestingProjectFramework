using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string email = "amitesdfsdfh@gmail.com";
        IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }


        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                String title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click();
                String registertitle = driver.Title;
                Assert.AreEqual(registertitle, "Demo Web Shop. Register");

                driver.FindElement(By.Id("gender-male")).Click();

                driver.FindElement(By.Id("FirstName")).SendKeys("Amitesh");

                driver.FindElement(By.Id("LastName")).SendKeys("Rawal");

                driver.FindElement(By.Id("Email")).SendKeys(email);

                driver.FindElement(By.Name("Password")).SendKeys("Password");

                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Password");

                driver.FindElement(By.Id("register-button")).Click();

                string message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");


                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);

                driver.FindElement(By.ClassName("ico-logout")).Click();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }





        }
        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
