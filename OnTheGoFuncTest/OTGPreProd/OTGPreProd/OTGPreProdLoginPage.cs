using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace OTGPreProd
{

    public class OTGPreProdLoginPage
   {
        protected readonly IWebDriver WebDriver;

        public OTGPreProdLoginPage(IWebDriver webdriver)
        {
            this.WebDriver = webdriver;

            string title = WebDriver.Title;

            
        }

        /*
        A property to enter username on login page
     */
        public string EnterUsername
        {
            set
            {
                IWebElement usernameField = WebDriver.FindElement(By.Id("UserName"));
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

        /*
        A method to click the login button on the page
     */
        public void ClickLogin()
        {
            IWebElement loginButton = WebDriver.FindElement(By.Id("btnLogin")); ; // find the login button
             
            loginButton.Click(); // click on the login button
        }
    }
}    