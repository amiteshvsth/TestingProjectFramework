using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProject1.BasePage;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {

        public HomePage homepage;
        public RegisterPage registerPage;
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyRegisterFunctionalityWithValidData()
        {
            homepage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homepage.GetTitle(), "Demo Web Shop");
            homepage.ClickRegisterLink();

            Assert.AreEqual(registerPage.GetTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleGender();
            registerPage.EnterFirstName("Amitesh");
            registerPage.EnterLastName("Rawal");
            registerPage.EnterEmail("amit@h.com");
            registerPage.EnterPassword("Password");
            registerPage.EnterConfirmPassword("Password");
            registerPage.ClickRegisterButton();
            String result = registerPage.GetSuccessfullMessage(); ;
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("amit@h.com");
            Assert.IsTrue(isTrue);
            registerPage.ClickLogout();
        }
        [TestCategory("UnitTest")]
        [TestMethod]
        public void VerifyAppLogoDisplayed()
        {

        }
    }
}
