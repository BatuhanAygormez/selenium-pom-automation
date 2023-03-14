using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;


/// <summary>
/// Driver setups
/// </summary>
namespace MyProject.Utils
{
    [TestFixture]
    public class Driver
    {
        public static IWebDriver Driver_;
        public int pageLoad = 120;

        public IWebDriver Get()
        {
            if (Driver_ == null)
            {
                string indirmeYolu = AppDomain.CurrentDomain.BaseDirectory + @"Downloads\";

                if (!Directory.Exists(indirmeYolu)) // Downloads klasörünün varlığını kontrol edip, yoksa oluşturuyor.
                    Directory.CreateDirectory(indirmeYolu);

                switch (Globals.Default.browser.ToLower())
                {
                    case "chrome":
                        var options = new ChromeOptions();
                        options.AddUserProfilePreference("download.default_directory", indirmeYolu);
                        options.AddArgument("no-sandbox");
                        options.AddArgument("--start-maximized");

                        Driver_ = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options: options, commandTimeout: TimeSpan.FromMinutes(3));
                        break;

                    case "chrome-headless":
                        var chromeHeadless = new ChromeOptions();
                        chromeHeadless.AddUserProfilePreference("download.default_directory", indirmeYolu);
                        chromeHeadless.AddArgument("no-sandbox");
                        chromeHeadless.AddArgument("--headless");
                        chromeHeadless.AddArgument("--start-maximized");

                        Driver_ = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options: chromeHeadless, commandTimeout: TimeSpan.FromMinutes(3));
                        break;

                    case "firefox":
                        var firefoxOptions = new FirefoxOptions();
                        firefoxOptions.SetPreference("download.default_directory", indirmeYolu);

                        Driver_ = new FirefoxDriver(options: firefoxOptions);
                        break;

                    case "firefox-headless":
                        var firefoxHeadless = new FirefoxOptions();
                        firefoxHeadless.SetPreference("download.default_directory", indirmeYolu);
                        firefoxHeadless.AddArgument("--headless");

                        Driver_ = new FirefoxDriver(options: firefoxHeadless);
                        break;

                    case "edge":
                        var edgeOptions = new EdgeOptions();
                        edgeOptions.AddUserProfilePreference("download.default_directory", indirmeYolu);
                        edgeOptions.AddArgument("no-sandbox");

                        Driver_ = new EdgeDriver(options: edgeOptions);
                        break;

                    default:
                        break;
                }
            }

            Driver_.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Driver_.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoad); // Arama Süresi buradan geliyor bu değişmesi lazım      helper ->     TenMunitesFrameToBeAvailableAndSwitchToIt 
            return Driver_;
        }

        public void CloseDriver()
        {
            if (Driver_ != null)
            {
                Driver_.Quit();
                Driver_ = null;
            }
        }

    }
}
