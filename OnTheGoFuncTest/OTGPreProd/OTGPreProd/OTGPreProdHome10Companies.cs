using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using NUnit.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;

using OpenQA.Selenium.Support.UI;
 
using System.Collections.Specialized;


namespace OTGPreProd
{
    [TestFixture]
    public class OTGPreProdHome10Companies
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        private string username;
        private string userpw;
        private int isleep;
        private string myurl;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //baseURL = "https://testpreprod-onthego.adppcloudsites.myob.com/";
            verificationErrors = new StringBuilder();
            username = "onthego@myob.com";
            userpw = "Password1";
            isleep = 6000;
            myurl = ConfigurationManager.AppSettings["cururl"];

            switch (myurl.ToLower())
            {
                case "preprodurl":
                    baseURL = ConfigurationManager.AppSettings["preprodurl"];
                    Console.WriteLine(baseURL);
                    break;
                case "produrl" :
                    baseURL = ConfigurationManager.AppSettings["produrl"];
                    Console.WriteLine(baseURL);
                    break;
                default:
                    baseURL = ConfigurationManager.AppSettings["preprodurl"];
                    Console.WriteLine(baseURL);
                    break;
            }
        }


        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        [Test]
        public void TheOTGPreProdHome10CompaniesTest()
        {
            string[] myCompanyArray =
                {   "Graceland Pastoral Pty Ltd"
                    ,"Clear Policies Ltd"
                 
                };

            /*
             *    , "Bad Pty Ltd"
                    , "Abbot and Rankine Pty Limited"
                    , "Verby Limited"
                    , "Kingston Smith Pty Ltd"
                    , "Crewkerne Limited"
                    , "Balthazar Marketing"
                    , "Sports Group Pty Ltd"
                    , "Wollongong Equipment Pty Ltd"
             * */
            //login for every test
            driver.Navigate().GoToUrl(baseURL + "/Login");

            OTGPreProdLoginPage login = new OTGPreProdLoginPage(driver);

            login.EnterUsername = username;
            Thread.Sleep(isleep);

            login.EnterPassword = userpw;

            login.ClickLogin();

            Thread.Sleep(isleep);

            OTGPreProdHomePage home = new OTGPreProdHomePage(driver);

            foreach (string value in myCompanyArray)
            {
         
            driver.FindElement(By.LinkText(value)).Click();
            Thread.Sleep(isleep);
            //Console.WriteLine("driver Title=   ", driver.Title);
            //Console.WriteLine("current  URL=   ", driver.Url);
            //Console.WriteLine("Top 10 Debtors=   ", driver.FindElement(By.CssSelector("h3")).Text);
            Thread.Sleep(isleep);
            driver.Navigate().Back();
            }

        
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}


//driver.FindElement(By.Id("UserName")).Clear();
//driver.FindElement(By.Id("UserName")).SendKeys("OTGPreProd@myob.com");
//driver.FindElement(By.Id("Password")).Clear();
//driver.FindElement(By.Id("Password")).SendKeys("Password1");
//driver.FindElement(By.Id("btnLogin")).Click();

/*
           Assert.IsTrue(IsElementPresent(By.CssSelector("h3")));
           Assert.AreEqual("Home", driver.Title);
           Assert.AreEqual("Top 10 Debtors", driver.FindElement(By.CssSelector("h3")).Text);
            * */