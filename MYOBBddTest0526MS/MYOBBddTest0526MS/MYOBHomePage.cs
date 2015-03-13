using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace MYOBBddTest0526MS

{
 class  MYOBHomePage : BasePage
         {
         private static readonly String Url = "http://www.myob.com";
        //Contructor to re-use the driver
         public  MYOBHomePage(IWebDriver driver) : base(driver, Url)
         {
         }
 
       
 
 public void GoToLink(string keyword)
 {
     WebBrowser.Current.FindElement(By.LinkText(keyword)).Click();
         // driver.FindElement(By.LinkText("Support")).Click();
 
 // Wait for the page to load, timeout after 3 seconds
     System.Threading.Thread.Sleep(3000);
  
  
 }

 }
}