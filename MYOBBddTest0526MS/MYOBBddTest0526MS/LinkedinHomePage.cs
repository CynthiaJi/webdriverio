using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MYOBBddTest0526MS
{
    public class LinkedinHomePage
    {
        protected readonly IWebDriver WebDriver;

        public LinkedinHomePage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;

            string title = WebDriver.Title;
            String title2 = webdriver.Title;
            Console.WriteLine(title);
            //"Welcome, Kate! | LinkedIn"
            if (!title.Equals(title2))
            {
                //throw new InvalidOperationException("This is not the HomePage. Current page is: " + title);
                Console.WriteLine("This is not the HomePage. Current page is: " + title);
            }
        }

        /*
        A method to logout of LinkedIn
        */

        public void Logout()
        {
            //driver.Navigate().GoToUrl(baseURL + "/nhome/?trk=hb_signin");
            WebDriver.FindElement(By.LinkText("Sign Out")).Click();
            //driver.   FindElement(By.LinkText("Sign Out")).Click();
        }
    }
}