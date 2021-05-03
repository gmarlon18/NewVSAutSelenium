using OpenQA.Selenium;
using System;
using NewVSAutSelenium.Driver;
using NewVSAutSelenium.PageObjects;
using NUnit.Framework;

namespace NewVSAutSelenium.Tests
{
    public class BaseTest
    {

        private IWebDriver Driver { get; set; }

        [SetUp]
        public void TestSetup()
        {
            var factory = new Factory();
            Driver = factory.GetChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ExistingPages.Init(Driver);
        }

        [TearDown]
        public void TestEnding()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
