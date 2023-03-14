using MyProject.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace MyProject.Utils
{
    public class Helper
    {
        Driver _driver;
        IWebDriver driver;
        private object ExpectedConditions;
        readonly WebDriverWait Wait;

        public Helper()
        {
            _driver = new Driver();
            driver = _driver.Get();
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }


        public void NonClickableSendkeys(IWebElement element, String value)
        {
            element.SendKeys(value);
        }
        public void ClickElement(IWebElement element, bool waitForClickable = true)
        {
            if (waitForClickable)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }

            if (element.Displayed && element.Enabled)
            {
                element.Click();
            }
        }


        public void NonWaitClickSendKeys(IWebElement element, String value)
        {
            element.SendKeys(value);
        }

        public void JsClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public void JsSendValue(IWebElement element, string value)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].value='" + value + "';", element);
        }

        public void WaitForAjax()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        public void OpenNewTab()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public void SwitchTabToFirst()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }
        public void SwitchTabToLast()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public string GetCurrentUrl()
        {
            string currentUrl = driver.Url;
            return currentUrl;
        }

        public void ClickCoordinates(IWebElement element)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 10, 25).Click().Build().Perform();
        }

        public Boolean isElementExist(By locator, int timeOut = 0)
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOut);
                driver.FindElement(locator);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (NoSuchElementException e)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                return false;
            }

            return true;
        }

        public void DoubleClickElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.DoubleClick().Build().Perform();
        }
    }
}


/// <summary>
/// Helps for any action to elements
/// </summary>