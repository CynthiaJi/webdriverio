using System;
using System.Collections;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using SpecFlow.Specs.StepDefinitions.Helpers;
using OpenQA.Selenium.Remote;




namespace SpecFlow.Specs.StepDefinitions.PageFactory
{
    public class BasePage
    {
        protected readonly RemoteWebDriver Driver;


        public BasePage(RemoteWebDriver driver)
            {
                this.Driver = driver;
                //AngularScripts.WaitForAngular(driver);
                OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(driver, this);
            }

       
        //The logging function here is supposed to log java scripts error. Other errors should be recorded by webdriver standard out put
        // the expection is that we can detect page on load error and other js error. following method will be part of base page object method
        //public string Jserroronloading(WebDriver driver)
        //{
        //    var js = driver as IJavaScriptExecutor;
        //    ICollection javascriptErrors = null;
        //    for (var i = 0; i < 20; i++)
        //    {
        //        javascriptErrors = js.ExecuteScript("return window.jsErrors") as ICollection;
        //        if (javascriptErrors != null) break;
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //    Assert.IsNotNull(javascriptErrors, "Can't seem to load JavaScript on the page to find JavaScript errors. Check that JavaScript is enabled.");
        //    var javaScriptErrorsAsString = javascriptErrors.Cast<string>().Aggregate("", (current, error) => current + (error + ", "));
        //    Assert.AreEqual("", javaScriptErrorsAsString, "Found JavaScript errors on page load: " + javaScriptErrorsAsString);
        //    return javaScriptErrorsAsString;
        //}

        // following method should be called when we need take a snapshot
        /*
        public void Snapshot(WebDriver driver, string filename)
        {
            Screenshot ss = driver.GetScreenshot();
            //string screenshot = ss.AsBase64EncodedString;
            //byte[] screenshotAsByteArray = ss.AsByteArray;
            ss.SaveAsFile(filename, ImageFormat.Jpeg);
        }
         * **/

        // wait for angular page to be loaded 
        public void waitForPageLoading(RemoteWebDriver driver)
        {
            driver.ExecuteAsyncScript("var callback = arguments[arguments.length - 1];" +
                                      "angular.element(document.body).injector().get('$browser').notifyWhenNoOutstandingRequests(callback);");
        }

    }
}