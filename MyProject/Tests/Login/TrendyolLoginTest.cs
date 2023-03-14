using MyProject.Actuals.Login;
using MyProject.Pages;
using MyProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyProject.Tests.Login
{
    public class TrendyolLoginTest
    {
        private TrendyolLoginActuals _actuals;
        private Verify _verify;
        private TrendyolLoginPages _do;
        private Helper _helper;
        private GeneralMethods _generalMethods;
        private int i = 0;

        [OneTimeSetUp]
        public void Init()
        {
            _do = new TrendyolLoginPages();
            _verify = new Verify();
            _actuals = new TrendyolLoginActuals();
            _helper = new Helper();
            _generalMethods = new GeneralMethods();
        }
        public enum SeverityLevel
        {
            Critical,
            High,
            Medium,
            Low
        }
        [SetUp]
        public void Before()
        {
            _do.GoToUrl();
            _do.ClickClosePopUp();
            _do.ClickCookieOKButton();
        }
        [Test]
        [Order(1)]
        [Category("Login")]
        [Description("Login Butonuna tıklama testi")]
        public void TrendyolLoginButton()
        {
            _do.LoginHover();
            _do.Wait(2000);
            //_do.ClickLoginButton();

        }

    }

}
