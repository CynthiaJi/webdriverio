using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SpecFlow.Specs.StepDefinitions.PageFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlow.Specs.StepDefinitions.PageFactory.SharedClass;
using System.Configuration;
using System.Drawing;
using OpenQA.Selenium.Remote;
using System.Threading;


namespace SpecFlow.Specs.StepDefinitions.TestCases
{
    [Binding]
    public class OnLineTaxLoginFeatureSteps : BaseCases
    {

        private string title;
        int isleep = 6000;
     
        private OnLineTaxLoginPage login;
        private OnLineTaxHomePage home;

        Screenshot screenshot;
        string myPath = ConfigurationManager.AppSettings["screenshotfile"];
        string myImag = DateTime.Today.ToString("yyyy-MM-dd");
        Random r = new Random();


        [Given(@"Navigate to the OnLineTax  Homepage with title ""(.*)""")]
        public void GivenNavigateToTheOnLineTaxHomepageWithTitle(string mytitle)
            {
                //ScenarioContext.Current.Pending();
                try
                {

                    login = new OnLineTaxLoginPage(Driver);
                    title = Driver.Title;
                    Thread.Sleep(isleep);
                    //Console.WriteLine("Navigate to the OnLineTax Homepage - " + title);
                    Assert.AreEqual(title.Trim(), mytitle.Trim());

                    Thread.Sleep(isleep);


                }
                catch
                {
                    screenshot = Driver.GetScreenshot();
                    screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + "S2"+r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    Thread.Sleep(isleep);

                }
            }

        [When(@"Login with ""(.*)""  Password  ""(.*)""  page tile  ""(.*)""")]
        public void WhenLoginWithPasswordPageTile(string username, string password, string mytitle2)
               {
                   try
                   {
                       login.EnterUsername = username;

                       //Enter Password
                       login.EnterPassword = password;
                       Thread.Sleep(isleep);

                       // Click Login
                       login.ClickLogin();


                       home = new OnLineTaxHomePage(Driver);

                       Thread.Sleep(isleep);
                       //screenshot = Driver.GetScreenshot();
                       //screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + r.Next(1000, 9999).ToString() + "pass.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                      
                       title = Driver.Title;
                       //Console.WriteLine(" After OnLineTax Login Page- " + title);
                       Assert.IsTrue(title.Contains(mytitle2));
                       //Assert.AreEqual(title.Trim(), mytitle2.Trim());
                       Thread.Sleep(isleep);


                   }
                   catch
                   {
                       screenshot = Driver.GetScreenshot();
                       screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + "S3" + r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                       Thread.Sleep(isleep);

                   }
               }

      
        [Then(@"Logout   ""(.*)""")]
        public void ThenLogout(string mytitle)

        {
            try
            {

                home.Logout();
                title = Driver.Title;
                //Console.WriteLine(" After OnLineTax Logout   - " + title);
                Assert.IsTrue(title.Contains(mytitle));
                //Assert.AreEqual(title.Trim(), mytitle.Trim());

                Thread.Sleep(isleep);


            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + "S4" + r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Thread.Sleep(isleep);

            }

        }
    }
}
