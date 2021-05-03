using NewVSAutSelenium.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVSAutSelenium.PageObjects
{
    public class BasePage
    {
        protected Helpers Helper { get; }

        protected BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }
    }
}
