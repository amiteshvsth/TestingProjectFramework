using OpenQA.Selenium;
using UnitTestProject1.WebDriverExtensions;

namespace UnitTestProject1.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            LoginPage.driver = driver;
        }

        //Page objects
        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginBtn = By.CssSelector("input.button-1.login-button");
        public static readonly By logoutBtn = By.ClassName("ico-logout");

        // Page Methods
        public string GetTitle()
        {
            return driver.Title;
        }

        public void EnterEmailAddress(string email)
        {
            driver.EnterText(emailtxt, email);
        }

        public void EnterPassword(string password)
        {
            driver.EnterText(passwordtxt, password);
        }

        public void ClickLoginButton()
        {
            driver.Click(loginBtn);
        }

        public void ClickLogoutButton()
        {
            driver.Click(logoutBtn);
        }

    }
}
