using OpenQA.Selenium;
using UnitTestProject1.WebDriverExtensions;

namespace UnitTestProject1.Pages
{
    public class HomePage
    {

        //Instance of WebDriver
        public static IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        //Page Objects - for webelements
        public static By registerlink = By.ClassName("ico-register");
        public static By loginLink = By.ClassName("ico-login");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }


        public void ClickRegisterLink()
        {
            driver.Click(registerlink);
        }

        public void ClickLoginLink()
        {
            driver.Click(loginLink);
        }

    }
}
