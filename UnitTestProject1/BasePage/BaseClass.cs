using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace UnitTestProject1.BasePage
{
    /*
     *  Initialize the Driver - Setup Driver
     *  Resuable methods
     */
    public class BaseClass
    {
        public static IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            string siteurl = ConfigurationManager.AppSettings["Url"];
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(siteurl);
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
