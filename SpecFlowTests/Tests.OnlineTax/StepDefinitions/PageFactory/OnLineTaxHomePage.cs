using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.PageObjects;


namespace SpecFlow.Specs.StepDefinitions.PageFactory
{
    public class OnLineTaxHomePage
   {
        protected readonly IWebDriver WebDriver;
        public string baseURL = "https://test.secure.myob.com/";
        string mytitle = "Practice Online";

        public OnLineTaxHomePage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;

            string title = WebDriver.Title;
            //Console.WriteLine("Current Title is         "+title);
            //"Practice Online"
            if (!title.Equals(mytitle))
            {
                throw new InvalidOperationException("This is not the HomePage. Current page is: "
                                                    + title);
            }
        }

        /*
A method to logout of OnLineTax
         * driver.Navigate().GoToUrl(baseURL + "/oauth2");
            driver.FindElement(By.LinkText("Sign out")).Click();
*/
        public OnLineTaxLoginPage Logout()
        {
            this.WebDriver.Navigate().GoToUrl(baseURL + "/oauth2");
            this.WebDriver.FindElement(By.LinkText("Sign Out")).Click();
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(this.WebDriver, (new OnLineTaxLoginPage(this.WebDriver)));
            return new OnLineTaxLoginPage(this.WebDriver);

        }

        public OnLineTaxLoginPage Login()
        {
            IWebElement loginButton = this.WebDriver.FindElement(By.Id("signin")); // find the login button
            loginButton.Click(); // click on the login button

            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(this.WebDriver, (new OnLineTaxLoginPage(this.WebDriver)));
            return new OnLineTaxLoginPage(this.WebDriver);

        }
    }
}
 