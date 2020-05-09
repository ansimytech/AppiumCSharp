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
using SeleniumExtras.PageObjects;
using System.IO;

namespace MobileAppAutomation.AllPages
{
    public class FirstPage
    {
        [FindsBy(How = How.Id, Using = "au.com.recyclerview:id/tv_animal_type")]
        private IList<IWebElement> animalList;

        public string displayText()
        {
            return animalList[0].Text;
        }

    }
}
