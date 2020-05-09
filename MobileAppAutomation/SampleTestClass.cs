using System;
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
using MobileAppAutomation.AllPages;

namespace MobileAppAutomation
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Onboarding")]
    [AllureDisplayIgnored]
    public class SampleTestClass : BaseTest
    {
        [Test(Description = "View the RecyclerView Content")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuiteAttribute("Sample App")]
        [Category("CriticalRegression")]
        public void FirstTestMethod()
        {
            Pages pages = new Pages();
            string viewText = pages.fPage.displayText();
            Assert.IsTrue(true, viewText);
            
        }
    }
}
