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
    public class SpecFlowSampleFeatureSteps : BaseCases
    {
        private string title;
        int isleep = 6000;
        Screenshot screenshot;
        string myPath = ConfigurationManager.AppSettings["screenshotfile"];
        string myImag = DateTime.Today.ToString("yyyy-MM-dd");
        Random r = new Random();


        [Given(@"BrowserName ""(.*)""")]
        public void GivenBrowserName(string mybrowser)
        {
            
            UpdateConfig myconfig = new UpdateConfig();
            myconfig.newvalue = mybrowser;
            myconfig.MakeChangeToConfig(mybrowser);
            Thread.Sleep(isleep);
        }

        [When(@"Navigate to Google Homepage ""(.*)""")]
        public void WhenNavigateToGoogleHomepage(string GoogleHome)
        {
            //ScenarioContext.Current.Pending();
            try
            {
                Driver.Navigate().GoToUrl(GoogleHome);
                Thread.Sleep(isleep);

                
            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + r.Next(1000,9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Thread.Sleep(isleep);

            }
        }

        
        [When(@"search the word ""(.*)""")]
        public void WhenSearchTheWord(string myword)
        {
            
            try
            {
                Console.WriteLine(Driver.Title);

                IWebElement query = Driver.FindElement(By.Name("q"));
                query.SendKeys(myword);
             
                query.Submit();
                Thread.Sleep(isleep);
            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Thread.Sleep(isleep);

            }
        }

        [Then(@"Assert that page tile include ""(.*)""")]
        public void ThenAssertThatPageTileInclude(string myword)
        {
            //ScenarioContext.Current.Pending();
            try
            {
                title = Driver.Title;
                Console.WriteLine(title);
                Console.WriteLine("Browser Stack Browser:   " + ConfigurationManager.AppSettings["Browser"]);
                Assert.IsTrue(title.ToUpper().Contains(myword));
                 
                //screenshot = Driver.GetScreenshot();
                //screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] +  r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Thread.Sleep(isleep);
            }
            catch
            {
                screenshot = Driver.GetScreenshot();
                screenshot.SaveAsFile(myPath + myImag + ConfigurationManager.AppSettings["Browser"] + r.Next(1000, 9999).ToString() + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Thread.Sleep(isleep);

            }
        }
    }
}
