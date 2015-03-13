using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace MYOBBddTest0526MS
{
    [TestClass]
    public class LinkedinTestUnit2
    {
        [TestMethod]
        public void LinkedInTestMethod1()
        {
            IWebDriver _driver = new FirefoxDriver();
            string baseURL = "http://www.linkedin.com.au/";



            //public void VerifyThatYouCanLoginAndLogoutOfLinkedIn()

            // Create an instance of the Login Page
            _driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(3000);
            Console.WriteLine("Current Page Title: " + _driver.Title);

            LinkedinLoginPage login = new LinkedinLoginPage(_driver);


            //Enter Username
            login.EnterUsername = "cynthia.ji@myob.com";

            //Enter Password
            login.EnterPassword = "kateking";

            // Click Login

            login.ClickLogin();
            Thread.Sleep(3000);
            //Create an instance of the HomePage
            _driver.Navigate().GoToUrl(baseURL + "/nhome/?trk=hb_signin");
            LinkedinHomePage home = new LinkedinHomePage(_driver);


            //Assert that some text is displayed on the Home Page
            //LinkedIn Today:
            Assert.IsTrue(_driver.PageSource.Contains("LinkedIn"));

            //LogOut from LinkedIn
            //home.Logout();


            // Assert
            //Assert.IsTrue(_driver.Title.Equals("Signed Out | LinkedIn"));
            if (_driver != null)
            { _driver.Close();
                _driver.Dispose();
            }

        
        }
    }
}

        