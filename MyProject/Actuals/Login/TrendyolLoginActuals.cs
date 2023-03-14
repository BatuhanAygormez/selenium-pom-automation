using OpenQA.Selenium;
using MyProject.Utils;

namespace MyProject.Actuals.Login
{
    public class TrendyolLoginActuals : Helper
    {
        public class TrendyolLoginElements : Driver
        {
            #region /*IWebElement*/

            public IWebElement ApplicationsButton => Get().FindElement(By.XPath("//div[contains(@class,'menuTrigger_')]//button[contains(@type,'button')]"));

            #endregion
        }
    }
}

