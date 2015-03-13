using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
//using NUnit.Framework;
using NUnit.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MYOBBddTest0526MS
{
    [Binding]
    public class MYOBHomePageNavSteps
    {
        [Given(@"I am on the myob home page")]
        //step1
        public void GivenIAmOnTheMyobHomePage()
        {
            var myobHP = new MYOBHomePage(WebBrowser.Current);
            myobHP.GoToSite();
            string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 1- "+title);
            Assert.AreEqual(title, WebBrowser.Current.Title);


        }
        
        [When(@"I click a link with text ""(.*)""")]
        //step2
        public void WhenIClickALinkWithText(string mylinktext)
        {
            //ScenarioContext.Current.Pending();
            var myobHP = new MYOBHomePage(WebBrowser.Current);
            myobHP.GoToSite();
            string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 2 Before- " + title);
            //got to other page via linke text
            myobHP.GoToLink(mylinktext);
            //string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 2 Before- " + WebBrowser.Current.Title);
            //verify page title has changed
            Assert.AreNotEqual(title, WebBrowser.Current.Title);
        }
        
        [Then(@"I should see the page ""(.*)"" Loaded")]
        //step3
        public void ThenIShouldSeeThePageLoaded(string keyword)
        {
            //ScenarioContext.Current.Pending();
            var myobHP = new MYOBHomePage(WebBrowser.Current);
            myobHP.GoToLink(keyword);
            string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 3 " + title);
            Assert.AreEqual(title, WebBrowser.Current.Title);
        }
        [When(@"I check a new page with text ""(.*)""")]
        //step4
        public void WhenICheckANewPageWithText(string mylinktext)
        {
            //ScenarioContext.Current.Pending();
            var myobHP = new MYOBHomePage(WebBrowser.Current);
            myobHP.GoToSite();
            string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 4 Before- " + title);
            //got to other page via linke text
            myobHP.GoToLink(mylinktext);
            //string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 4 Before- " + WebBrowser.Current.Title);
            //verify page title has changed
            Assert.AreNotEqual(title, WebBrowser.Current.Title);
        }

        [Then(@"I should see the different page ""(.*)"" Loaded")]
        //step5
        public void ThenIShouldSeeTheDifferentPageLoaded(string keyword)
        {
            //ScenarioContext.Current.Pending();
            var myobHP = new MYOBHomePage(WebBrowser.Current);
            myobHP.GoToLink(keyword);
            string title = WebBrowser.Current.Title;
            Console.WriteLine("Current Title Step 5 - " + title);
            Assert.AreEqual(title, WebBrowser.Current.Title);
        }
        
    }
}
