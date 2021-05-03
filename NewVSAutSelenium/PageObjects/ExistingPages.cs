using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewVSAutSelenium.Driver;
using NewVSAutSelenium.PageObjects.Pages;
using NewVSAutSelenium.Tests;
using OpenQA.Selenium;

namespace NewVSAutSelenium.PageObjects
{
    internal class ExistingPages : BaseTest
    {

        public static HomePage home;
        public static SeleniumPage sele;
        public static GalleryPage gallery;

        public static void Init(IWebDriver driver)
        {
            home = new HomePage(driver);
            sele = new SeleniumPage(driver);
            gallery = new GalleryPage(driver);
        }


    }
}
