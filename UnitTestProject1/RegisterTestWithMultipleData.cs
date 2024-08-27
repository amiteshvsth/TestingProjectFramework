using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnitTestProject1.BasePage;
using UnitTestProject1.DataModel;

namespace UnitTestProject1
{
    
    [TestClass]
    public class RegisterTestWithMultipleData : BaseClass
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\\Users\\amitesh\\source\\repos\\UnitTestProject1\\UnitTestProject1\\TestData\\RegisterData.json"));
            for (int i = 0; i < userdata.RegisterDataModels.Count; i++)
            {
                string fname = userdata.RegisterDataModels[i].FirstName;
                string lname = userdata.RegisterDataModels[i].LastName;
                string email = userdata.RegisterDataModels[i].Email;
                string password = userdata.RegisterDataModels[i].Password;

                driver.FindElement(By.ClassName("ico-register")).Click();
                String registertitle = driver.Title;
                Assert.AreEqual(registertitle, "Demo Web Shop. Register");

                driver.FindElement(By.Id("gender-male")).Click();

                driver.FindElement(By.Id("FirstName")).SendKeys(fname);

                driver.FindElement(By.Id("LastName")).SendKeys(lname);

                driver.FindElement(By.Id("Email")).SendKeys(email);

                driver.FindElement(By.Name("Password")).SendKeys(password);

                driver.FindElement(By.Id("ConfirmPassword")).SendKeys(password);

                driver.FindElement(By.Id("register-button")).Click();

                string message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                driver.FindElement(By.ClassName("ico-logout")).Click();

            }
        }
    }
}
