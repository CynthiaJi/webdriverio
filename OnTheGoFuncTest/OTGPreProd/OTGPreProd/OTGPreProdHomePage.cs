using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace OTGPreProd
{
    public class OTGPreProdHomePage
    {
        //private static readonly String Url = "https://testpreprod-onthego.adppcloudsites.myob.com/";

        protected readonly IWebDriver WebDriver;

        public OTGPreProdHomePage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;

            string title = WebDriver.Title;


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