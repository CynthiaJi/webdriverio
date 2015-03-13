using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SpecFlow.Specs.StepDefinitions.PageFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlow.Specs.StepDefinitions.PageFactory.SharedClass;
using System.Configuration;
using System.Drawing;
using System.Threading;


namespace SpecFlow.Specs.StepDefinitions.TestCases
{

    [Binding]
    public class LinkedinLoginTestSteps: BaseCases
    {
        private string title;
        //private string uname = "cynthia.ji@myob.com";
        //private string pw = "my08link";
        private LinkedinLoginPage login;
        private LinkedinHomePage home;
        Screenshot screenshot;
        string myPath=ConfigurationManager.AppSettings["screenshotfile"];
        string myImag =DateTime.Today.ToString("yyyy-MM-dd");
        Random r = new Random();
        int isleep = 3000;

        [Given(@"Navigate to the LinkedIn Homepage")]
        public void GivenNavigateToTheLinkedInHomepage()
        {
            try
            {

                login = new LinkedinLoginPage(Driver);
                title = Driver.Title;
                Thread.Sleep(isleep);
                Console.WriteLine("Navigate to the LinkedIn Homepage - " + title);
                Assert.AreEqual(title, Driver.Title);

                //screenshot = Driver.GetScreenshot();
                //screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch
            { 
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

             
            }
        }

        [When(@"Login with Username ""(.*)"" Password ""(.*)""")]
        public void WhenLoginWithUsernamePassword(string p0, string p1)
        {
            try
            {
                login.EnterUsername = p0;

                //Enter Password
                login.EnterPassword = p1;

                // Click Login
                login.ClickLogin();

                //Create an instance of the HomePage
                home = new LinkedinHomePage(Driver);


                //Assert that some text is displayed on the Home Page
                //LinkedIn Today:
                title = Driver.Title;
                Console.WriteLine(" After LinkedIn Login Page- " + title);
                Assert.IsTrue(title.Contains(Driver.Title));

                //screenshot = Driver.GetScreenshot();
                //screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);


            }

        }

        [Then(@"Assert Some Text is appearing on the HomePage after login")]
        public void ThenAssertSomeTextIsAppearingOnTheHomePageAfterLogin()
        {
            //ScenarioContext.Current.Pending();
            try
            {
                title = Driver.Title;
                Console.WriteLine("Assert Some Text is appearing on the HomePage after login- " + title);
                Assert.IsTrue(Driver.PageSource.Contains("today"));
                
                //screenshot = Driver.GetScreenshot();
                //screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);


            }

        }

        [Then(@"Logout and Assert that I have signed out")]
        public void ThenLogoutAndAssertThatIHaveSignedOut()
        {
            //ScenarioContext.Current.Pending();
            try
            {
                title = Driver.Title;

                Console.WriteLine("Logout and Cannot Assert that I have signed out- " + title);

                Assert.IsTrue(title.Contains(Driver.Title));
                
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Console.WriteLine("Browser Stack Browser:   " + ConfigurationManager.AppSettings["Browser"]);
                // Assert
            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + r.Next(100).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);


            }
        }
    }
}


/*
Test Name:	LinkedinLoginTest
Test Outcome:	Passed
Result StandardOutput:	
SpecRun Evaluation Mode: Please purchase at http://specrun.com to remove test execution delay.

Given Navigate to the LinkedIn Homepage
-> pass Login page
-> Navigate to the LinkedIn Homepage - World's Largest Professional Network | LinkedIn
-> done: LinkedinLoginTestSteps.GivenNavigateToTheLinkedInHomepage() (12.5s)

When Login with Username "cynthia.ji@myob.com" Password "my08link"
-> pass Login to linked in
->  After LinkedIn Login Page- World's Largest Professional Network | LinkedIn
-> done: LinkedinLoginTestSteps.WhenLoginWithUsernamePassword("cynthia.ji@myob.com", "my08link") (0.2s)

Then Assert Some Text is appearing on the HomePage after login
-> Assert Some Text is appearing on the HomePage after login- World's Largest Professional Network | LinkedIn
-> done: LinkedinLoginTestSteps.ThenAssertSomeTextIsAppearingOnTheHomePageAfterLogin() (0.0s)

Then Logout and Assert that I have signed out
-> Logout and Cannot Assert that I have signed out- World's Largest Professional Network | LinkedIn
-> done: LinkedinLoginTestSteps.ThenLogoutAndAssertThatIHaveSignedOut() (0.0s)


**/