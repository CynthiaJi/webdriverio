using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MYOBBddTest0526MS
{
     public class LinkedinLoginPage
     
    {
        protected readonly IWebDriver WebDriver;

        public LinkedinLoginPage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;

            string title = WebDriver.Title;
            //World's Largest Professional Network | LinkedIn
            Console.WriteLine("Current Title = "+title);
            //"Australia | LinkedIn"
            if (!title.Equals(title))
            {
                throw new InvalidOperationException("This is not the Login Page. Current page is: "+ title);
            }
        }

        /*
            A property to enter username on login page
         */
        public string EnterUsername
        {
            set
            {
                IWebElement usernameField = WebDriver.FindElement(By.Id("session_key-login"));
                usernameField.Clear();
                usernameField.SendKeys(value);
            }
        }

        /*
            A property to enter password on login page
         */
        public string EnterPassword
        {
            set
            {
                IWebElement passwordField = WebDriver.FindElement(By.Id("session_password-login"));
                passwordField.Clear();
                passwordField.SendKeys(value);
            }
        }

        /*
            A method to click the login button on the page
         */
        public void ClickLogin()
        {
            //"btn-login"
            //id=signin
            IWebElement loginButton = WebDriver.FindElement(By.Id("signin")); // find the login button
            //                           driver.FindElement(By.Id("signin")).Click();
            loginButton.Click(); // click on the login button
        }
    }
}