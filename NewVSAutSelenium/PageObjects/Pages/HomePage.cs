using NewVSAutSelenium.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewVSAutSelenium.PageObjects.Pages
{
    public class HomePage : BasePage
    {

        //Locators

        public IWebElement point1 => Helper.LocateElement(Locators.Xpath, "//*[@id='fs_pagination']/li[1]/a");
        public IWebElement point2 => Helper.LocateElement(Locators.Xpath, "//*[@id='fs_pagination']/li[2]/a");
        public IWebElement point3 => Helper.LocateElement(Locators.Xpath, "//*[@id='fs_pagination']/li[3]/a");
        public IWebElement point4 => Helper.LocateElement(Locators.Xpath, "//*[@id='fs_pagination']/li[4]/a");
        public IWebElement point5 => Helper.LocateElement(Locators.Xpath, "//*[@id='fs_pagination']/li[5]/a");
        public IWebElement correo => Helper.LocateElement(Locators.ID, "newsletter");
        public IWebElement subscribe => Helper.LocateElement(Locators.ID, "subscribe");

        //Variables

        public string User = "Marlon Jimenez";


        public HomePage(IWebDriver driver) : base(driver)
        {
           
        }

        public void GoTo()
        {
            Helper.GoToUrl("http://tallerselenium.azurewebsites.net/Home/Index");
        }

        public void CheckElements()
        {
            point1.Click();

            point2.Click();

            point3.Click();

            point4.Click();

            point5.Click();

            correo.SendKeys(User);

            subscribe.Click();


           
        }

        public String subscribe_alert()
        {
            string errorText = Helper.GetAlertText();


            return errorText;

        }

        

    }
}
