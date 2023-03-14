using MyProject.Utils;
using OpenQA.Selenium;
using MyProject.Elements;
using MyProject.Utils;
using OpenQA.Selenium.Chrome;

namespace MyProject.Pages
{
    public class TrendyolLoginPages : TrendyolLoginElements
    {
        private readonly Helper _helper = new Helper();
        public void GoToUrl() => _helper.GoToUrl(Globals.Default.url);

        public void LoginHover() => _helper.ClickElement(base.LoginHoverElement);
        public void ClickLoginButton() => _helper.ClickElement(base.ClickLoginButtonElement);

        public void ClickClosePopUp() => _helper.ClickElement(base.ClosePopUpElement);
        public void ClickCookieOKButton() => _helper.ClickElement(base.CookieOKButtonElement);

        public void Wait(int milliseconds) => System.Threading.Thread.Sleep(milliseconds);
    }
}
