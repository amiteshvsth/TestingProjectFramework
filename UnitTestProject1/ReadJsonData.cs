using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.IO;
using UnitTestProject1.BasePage;
using UnitTestProject1.DataModel;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for ReadJsonData
    /// </summary>
    [TestClass]
    public class ReadJsonData 
    {
        [TestMethod]
        public void ReadJsonDataMultipleObjects()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\\Users\\amitesh\\source\\repos\\UnitTestProject1\\UnitTestProject1\\TestData\\RegisterData.json"));
            for (int i = 0; i < userdata.RegisterDataModels.Count; i++)
            {
                string fname = userdata.RegisterDataModels[i].FirstName;
                string lname = userdata.RegisterDataModels[i].LastName;
                string email = userdata.RegisterDataModels[i].Email;
                string password = userdata.RegisterDataModels[i].Password;

                Console.WriteLine("==================================");
                Console.WriteLine(fname+lname+email+password);  

            }
        }
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            string readdatafromjson = File.ReadAllText(@"C:\Users\amitesh\source\repos\UnitTestProject1\UnitTestProject1\TestData\userdata.json");
            var registerData = JsonConvert.DeserializeObject<DataModel.RegisterDataModel>(readdatafromjson);

            Console.WriteLine(registerData.FirstName);
            Console.WriteLine(registerData.LastName);
            Console.WriteLine(registerData.Email);
            Console.WriteLine(registerData.Password);
        }
    }
}
