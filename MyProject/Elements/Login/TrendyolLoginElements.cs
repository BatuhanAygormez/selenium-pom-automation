using OpenQA.Selenium;
using MyProject.Utils;

namespace MyProject.Elements
{
    public class TrendyolLoginElements : Driver
    {
        public IWebElement ApplicationsButton => Get().FindElement(By.XPath("//button[contains(@class, 'example-button')]"));
        public IWebElement ExampleInput => Get().FindElement(By.XPath("//input[contains(@class, 'example-input')]"));
        public IWebElement LoginHoverElement => Get().FindElement(By.XPath("//p[contains(@class,'link-text')and text()='Giriş Yap']"));
        public IWebElement ClickLoginButtonElement => Get().FindElement(By.XPath("//div[@class='login-button']"));
        public IWebElement ClosePopUpElement => Get().FindElement(By.XPath("//div[contains(@class,'modal-close')and contains(@title,'Kapat')]"));
        public IWebElement CookieOKButtonElement => Get().FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']"));

        //div[contains(@class,'modal-close')and contains(@title,'Kapat')]
    }
}
