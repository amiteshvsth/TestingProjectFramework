using OpenQA.Selenium;
using System;

namespace UnitTestProject1.WebDriverExtensions
{
    public static class WebDriverExtensions
    {

        //Common methodas or RE-Usable methods for page


        // Entertext in text boxes / Editboxes
        public static void EnterText(this IWebDriver driver, By locator, string value)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed && ele.Enabled)
            {
                ele.Clear();
                ele.SendKeys(value);

            }
        }

        // Click the button , radiobutton , checkboxes
        public static void Click(this IWebDriver driver, By locator)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed && ele.Enabled)
            {
                ele.Click();

            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed)
            {
                return true;
            }
            return false;
        }

        public static string GetText(this IWebDriver driver, By locator)
        {
            IWebElement ele = driver.FindElement(locator);
            var text = "";
            if (ele.Displayed)
            {
                text = ele.Text;
            }
            return text;
        }

        public static bool GetTextWithValue(this IWebDriver driver, String value)
        {
            var text = "";
            IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));

            if (ele.Displayed)
            {
                return true;
            }
            return true;
        }
    }
}
