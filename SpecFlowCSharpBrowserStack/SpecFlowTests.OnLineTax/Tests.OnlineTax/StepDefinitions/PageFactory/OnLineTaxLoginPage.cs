using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
 

namespace SpecFlow.Specs.StepDefinitions.PageFactory
{
    public class OnLineTaxLoginPage
   {
        protected readonly IWebDriver WebDriver;
        public string baseURL = "https://test.secure.myob.com/";

        public OnLineTaxLoginPage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;
            webdriver.Navigate().GoToUrl(baseURL + "/");
             
            string title = WebDriver.Title;
         

        }

        /*
        A property to enter username on login page
         * driver.FindElement(By.Id("Username")).Clear();
            driver.FindElement(By.Id("Username")).SendKeys("ivan@my.com");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("password1");
            driver.FindElement(By.Id("submit")).Click();
     */
        public string EnterUsername
        {
            set
            {
                IWebElement usernameField = WebDriver.FindElement(By.Id("Username"));
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
                IWebElement passwordField = WebDriver.FindElement(By.Id("Password"));
                passwordField.Clear();
                passwordField.SendKeys(value);
            }
        }
        public void ClickLogin()
        {
            IWebElement loginButton = WebDriver.FindElement(By.Id("submit")); // find the login button
            loginButton.Click(); // click on the login button
            Console.WriteLine("pass Login to On Line Tax");

        }

    }
}