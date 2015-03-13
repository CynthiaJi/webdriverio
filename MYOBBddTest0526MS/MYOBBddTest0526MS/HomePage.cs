using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace  MYOBBddTest0526MS
{

    public class HomePage
    {
        protected readonly IWebDriver WebDriver;
        private readonly string WebUrl = "www.myob.com";
        public HomePage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;
            webdriver.Navigate().GoToUrl(WebUrl);
            string title = WebDriver.Title;

            if (!title.Contains("MYOB"))
            {
                throw new InvalidOperationException("This is not the HomePage. Current page is: "+ title);
            }
        }

       

    }
}