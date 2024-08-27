using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Configuration;
using System.IO;
using UnitTestProject1.BasePage;
using UnitTestProject1.DataModel;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class LoginTestCopy : BaseClass
    {
        HomePage homepage;
        LoginPage loginpage;
        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyLoginFunctionalityWithValidData()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\\Users\\amitesh\\source\\repos\\UnitTestProject1\\UnitTestProject1\\TestData\\RegisterData.json"));
            for (int i = 0; i < userdata.RegisterDataModels.Count; i++)
            {
                string email = userdata.RegisterDataModels[i].Email;
                string password = userdata.RegisterDataModels[i].Password;

                homepage = new HomePage(driver);
                loginpage = new LoginPage(driver);
                homepage.ClickLoginLink();
                string title = homepage.GetTitle();
                Assert.AreEqual(title, "Demo Web Shop. Login");
                loginpage.EnterEmailAddress(email);
                loginpage.EnterPassword(password);
                loginpage.ClickLoginButton();
                loginpage.ClickLogoutButton();
            }
        }
    }
}
