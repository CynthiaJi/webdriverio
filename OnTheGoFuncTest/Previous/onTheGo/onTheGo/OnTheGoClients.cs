﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;

using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Collections.Specialized;


namespace onTheGo
{
    [TestFixture]
    public class OnTheGoClients
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        private string username;
        private string userpw;
        private int isleep;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://testpreprod-onthego.adppcloudsites.myob.com/";
            verificationErrors = new StringBuilder();
            username = "onthego@myob.com";
            userpw = "Password1";
            isleep = 6000;
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
        public void TheOnTheGoClientsTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login");
     
            OnTheGoLoginPage login = new OnTheGoLoginPage(driver);

            login.EnterUsername = username;
            login.EnterPassword = userpw;

            login.ClickLogin();

            OnTheGoHomePage home = new OnTheGoHomePage(driver);

            for (int i = 92; i < 99;i++ )
            {
                driver.Navigate().GoToUrl(baseURL + "/Clients#/details/" + i);
                Thread.Sleep(isleep);
            }
            //https://testpreprod-onthego.adppcloudsites.myob.com/Clients#/details/265
            
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
//driver.FindElement(By.Id("UserName")).SendKeys("onthego@myob.com");
//driver.FindElement(By.Id("Password")).Clear();
//driver.FindElement(By.Id("Password")).SendKeys("Password1");
//driver.FindElement(By.Id("btnLogin")).Click();

/*
            Console.WriteLine("driver Title=   ",driver.Title);
            Console.WriteLine("Top 10 Debtors=   ", driver.FindElement(By.CssSelector("h3")).Text);
            
            Assert.IsTrue(IsElementPresent(By.CssSelector("h3")));
            Assert.AreEqual("Home", driver.Title);
            Assert.AreEqual("Top 10 Debtors", driver.FindElement(By.CssSelector("h3")).Text);
             **/