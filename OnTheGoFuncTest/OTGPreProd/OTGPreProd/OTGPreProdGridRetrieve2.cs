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
    public class OTGPreProdGridRetrieve2
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
        public void TheOTGPreProdGridRetrieve2Test()
        {
            string mystr;
            logWriter3 mylog = new logWriter3();

            //Test
            //mylog.MyString("Good Luck!");

            IWebElement webElementHead;
            IList<IWebElement> ElementCollectionHead;

            IWebElement webElementBody;
            IList<IWebElement> ElementCollectionBody;

            driver.Navigate().GoToUrl(baseURL + "/Login");
     
            OTGPreProdLoginPage login = new OTGPreProdLoginPage(driver);

            login.EnterUsername = username;
            login.EnterPassword = userpw;

            login.ClickLogin();

            OTGPreProdHomePage home = new OTGPreProdHomePage(driver);


            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(isleep);

            mystr = "Driver Title=   "+driver.Title.ToString();
            mylog.MyString(mystr);
            mystr ="Top 10 Debtors=   "+driver.FindElement(By.CssSelector("h3")).Text;
            mylog.MyString(mystr);

            Thread.Sleep(isleep);

            mylog.MyString("WIP Table ......");
             if(driver.FindElement(By.XPath("//table[@id='wip']/thead/tr/th")).Displayed)
            {
                webElementHead =  driver.FindElement(By.XPath("//table[@id='wip']/thead/tr"));
                ElementCollectionHead = webElementHead.FindElements(By.XPath("//table[@id='wip']/thead/tr/th"));
                mystr = "";
                foreach (IWebElement item in ElementCollectionHead)
                {
                    //Console.WriteLine(item.Text);
                    mystr = mystr + item.Text+" ";
                    
                }
                mylog.MyString(mystr);
            }

             mystr = "";
             mylog.MyString("WIP Table Content......");
             if (driver.FindElement(By.XPath("//table[@id='wip']/tbody/tr")).Displayed)
             {
                 webElementBody = driver.FindElement(By.XPath("//table[@id='wip']/tbody/tr"));
                 ElementCollectionBody = webElementBody.FindElements(By.XPath("//table[@id='wip']/tbody/tr"));

                 foreach (IWebElement item in ElementCollectionBody)
                 {
                     string[] arr = new string[10];
                     arr = item.Text.Split(' ');
                     for (int i = 0; i < arr.Length; i++)
                     {
                         mystr = mystr + item.Text+" "; 
                         //mylog.MyString(arr[i] + "  ");
                         if (i % 8 == 7) { 
                             mylog.MyString(mystr);
                             mystr = "";
                         }
                     }
                 }
             }

             //Console.WriteLine();
            
        //table id="wip"
        //<table id="debtors" 

             mylog.MyString("Debtors Table ......  ");
             if (driver.FindElement(By.XPath("//table[@id='debtors']/thead/tr/th")).Displayed)
             {
                 webElementHead = driver.FindElement(By.XPath("//table[@id='debtors']/thead/tr"));
                 ElementCollectionHead = webElementHead.FindElements(By.XPath("//table[@id='debtors']/thead/tr/th"));
                 mystr = "";
                 foreach (IWebElement item in ElementCollectionHead)
                 {
                     
                     mystr = mystr + item.Text+" ";
                 }
                 mylog.MyString(mystr);

                  
             }

             mylog.MyString("Debtors Table Detail......");
             if (driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr")).Displayed)
             {
                 webElementBody = driver.FindElement(By.XPath("//table[@id='debtors']/tbody/tr"));
                 ElementCollectionBody = webElementBody.FindElements(By.XPath("//table[@id='debtors']/tbody/tr"));

                 mystr = "";
                 foreach (IWebElement item in ElementCollectionBody)
                 {
                     string[] arr = new string[10];
                     arr = item.Text.Split(' ');
                     //arr = item.Text.Split(' ');
                     for (int i = 0; i < arr.Length; i++)
                     {
                         //mylog.MyString(arr[i] + "  ");
                         mystr = mystr + arr[i] + " ";
                         if (i % 8 == 7) { mylog.MyString(mystr);
                             mystr = "";
                         }
                     }
                 }
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
