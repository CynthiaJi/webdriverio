using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace  MYOBBddTest0526MS
{
    class BasePage
    {
        private IWebDriver driver;
        private readonly string WebUrl;

        protected BasePage(IWebDriver driver, String loadUrl = "")
        {
            this.driver = WebBrowser.Current;
            WebUrl = loadUrl;
        }
        
        public void GoToSite()
        {
            driver.Navigate().GoToUrl(WebUrl);
        }

    }
}
