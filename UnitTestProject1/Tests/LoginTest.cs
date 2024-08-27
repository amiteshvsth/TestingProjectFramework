using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using UnitTestProject1.BasePage;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homepage;
        LoginPage loginpage;
        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];

            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            homepage.ClickLoginLink();
            string title = homepage.GetTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginpage.EnterEmailAddress(username);
            loginpage.EnterPassword(password);
            loginpage.ClickLoginButton();
        }
    }
}
