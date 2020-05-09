using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System.IO;
using MobileAppAutomation.TestData;

namespace MobileAppAutomation
{
    [TestFixture]
    public class BaseTest
    {

        public static AppiumDriver<RemoteWebElement> driver;

        [OneTimeSetUp]
        public static void setUp()
        {
            
            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", Config.deviceName);
            options.AddAdditionalCapability("platformVersion", Config.platformVersion);
            options.AddAdditionalCapability("automationName", Config.automationName);
            options.AddAdditionalCapability("appPackage", Config.appPackage);
            options.AddAdditionalCapability("appActivity", Config.appActivity);

            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<RemoteWebElement>(url, options);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static AppiumDriver<RemoteWebElement> getDriver
        {
            get { return driver; }
        }

        [OneTimeTearDown]
        public static void tearDown()
        {
            driver.Quit();
        }



    }
}
