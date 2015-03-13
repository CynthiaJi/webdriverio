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
using NUnit.ConsoleRunner;
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
    public class OTGPreProdGridRetrieve
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        private string username;
        private string userpw;
        private string myurl;
        private int isleep;

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
                case "produrl":
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
        public void TheOTGPreProdGridRetrieveTest()
        {
            string mystr;

            driver.Navigate().GoToUrl(baseURL + "/Login");
     
            OTGPreProdLoginPage login = new OTGPreProdLoginPage(driver);

            login.EnterUsername = username;
            login.EnterPassword = userpw;

            login.ClickLogin();

            OTGPreProdHomePage home = new OTGPreProdHomePage(driver);


            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(isleep);

            Console.WriteLine("Driver Title=   ", driver.Title);
            Console.WriteLine("Top 10 Debtors=   ", driver.FindElement(By.CssSelector("h3")).Text);

            Thread.Sleep(isleep);
            //"Graceland Pastoral Pty Ltd" 
            mystr = driver.FindElement(By.LinkText("Graceland Pastoral Pty Ltd")).Text;
            Console.WriteLine("Grid Company=   ", mystr);

            //mystr = driver.FindElement(By.XPath(//table[@id=\'debtors\']/tbody/tr/td[1]")).Text;
            mystr = driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr/td[1]")).Text;
            Console.WriteLine("Grid Company=   ", mystr);
             

            

            //"$246,436.73" 
            mystr = driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr/td[2]")).Text;
            Console.WriteLine("Grid Balance Money=   ", mystr);
            mystr = driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr/td[2]")).Text;
            Console.WriteLine("Grid Balance Money=   ", mystr);

            //"$80,960.00" 
            mystr = driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr[5]/td[2]")).Text;
            Console.WriteLine("Grid Balance Money=   ", mystr);

            
            
            
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
