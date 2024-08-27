using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;
using UnitTestProject1.BasePage;
using UnitTestProject1.DataModel;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class RegisterTestCopy : BaseClass
    {

        public HomePage homepage;
        public RegisterPage registerPage;
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyRegisterFunctionalityWithValidData()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\\Users\\amitesh\\source\\repos\\UnitTestProject1\\UnitTestProject1\\TestData\\RegisterData.json"));
            for (int i = 0; i < userdata.RegisterDataModels.Count; i++)
            {
                string fname = userdata.RegisterDataModels[i].FirstName;
                string lname = userdata.RegisterDataModels[i].LastName;
                string email = userdata.RegisterDataModels[i].Email;
                string password = userdata.RegisterDataModels[i].Password;
                homepage = new HomePage(driver);
                registerPage = new RegisterPage(driver);
                Assert.AreEqual(homepage.GetTitle(), "Demo Web Shop");
                homepage.ClickRegisterLink();

                Assert.AreEqual(registerPage.GetTitle(), "Demo Web Shop. Register");
                registerPage.SelectMaleGender();
                registerPage.EnterFirstName(fname);
                registerPage.EnterLastName(lname);
                registerPage.EnterEmail(email);
                registerPage.EnterPassword(password);
                registerPage.EnterConfirmPassword(password);
                registerPage.ClickRegisterButton();
                String result = registerPage.GetSuccessfullMessage(); ;
                Assert.AreEqual(result, "Your registration completed");
                bool isTrue = registerPage.IsEmailAccountDisplayed(email);
                Assert.IsTrue(isTrue);
                registerPage.ClickLogout();
            }
        }
        
    }
}
