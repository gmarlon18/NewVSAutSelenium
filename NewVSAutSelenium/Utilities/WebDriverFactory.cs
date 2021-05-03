using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NewVSAutSelenium.Driver
{

    internal class Factory
    {
        
        public IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver(options);
        }

        public IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver(options);
        }
        
    }
}
