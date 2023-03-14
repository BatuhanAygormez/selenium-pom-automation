using MyProject.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using MyProject.Actuals;
using MyProject.Pages;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MyProject.Utils
{
    public class GeneralMethods
    {
        private readonly Helper _helper;
        private readonly Verify _verify;

        private Driver _driver;
        public GeneralMethods()
        {
            _helper = new Helper();
            _verify = new Verify();
            _driver = new Driver();
        }

        public enum SeverityLevel
        {
            Critical,
            High,
            Medium,
            Low
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public class SeverityAttribute : PropertyAttribute
        {
            public SeverityAttribute(SeverityLevel level) : base(level.ToString()) { }
        }

        public void waitForAjax() => _helper.WaitForAjax();

        public void Wait(int sleep)
        {
            Thread.Sleep(sleep);
        }

        public void CloseDriver()
        {
            _driver.CloseDriver();
        }
        public void GoToUrl()
        {
            string url = "https://www.trendyol.com/"; // Varsayılan URL
            IWebDriver driver = new ChromeDriver(); // veya kullanmak istediğiniz başka bir WebDriver
            driver.Navigate().GoToUrl(url);
        }

    }
}
