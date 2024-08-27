using OpenQA.Selenium;
using System;
using UnitTestProject1.WebDriverExtensions;

namespace UnitTestProject1.Pages
{
    public class RegisterPage
    {
        public static IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            RegisterPage.driver = driver;
        }

        // page Objects
        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By firstname = By.Id("FirstName");
        public static readonly By lastname = By.Id("LastName");
        public static readonly By email = By.Id("Email");
        public static readonly By password = By.Name("Password");
        public static readonly By confirmpassword = By.Id("ConfirmPassword");
        public static readonly By registerbutton = By.Id("register-button");
        public static readonly By logout = By.ClassName("ico-logout");
        public static readonly By result = By.ClassName("result");

        //page methods
        public string GetTitle()
        {
            return driver.Title;
        }

        public void SelectMaleGender()
        {
            driver.Click(genderMale);
        }

        public void EnterFirstName(string value)
        {
            driver.EnterText(firstname, value);
        }

        public void EnterLastName(string value)
        {
            driver.EnterText(lastname, value);
        }

        public void EnterEmail(string value)
        {
            driver.EnterText(email, value);
        }

        public void EnterPassword(string value)
        {
            driver.EnterText(password, value);
        }

        public void EnterConfirmPassword(string value)
        {
            driver.EnterText(confirmpassword, value);
        }

        public void ClickRegisterButton()
        {
            driver.Click(registerbutton);
        }

        public String GetSuccessfullMessage()
        {
            return driver.GetText(result);
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.GetTextWithValue(email);
        }

        public void ClickLogout()
        {
            driver.Click(logout);
        }
    }

}
