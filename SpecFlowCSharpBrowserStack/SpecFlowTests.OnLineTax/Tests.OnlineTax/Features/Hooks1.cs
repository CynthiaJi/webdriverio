using System;
using System.IO;
using System.Configuration;
using System.Collections;
using TechTalk.SpecFlow;
using SpecFlow.Specs.StepDefinitions;
using OpenQA.Selenium;
using NLog;
//using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;

namespace SpecFlow.Specs.Features
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        private RemoteWebDriver _driver;
        private ArrayList _errorlog;
        private string title,tag;
        private static NLog.Logger log = LogManager.GetCurrentClassLogger();
         
        private void Teardown()
        {
            if (ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                _driver = ScenarioContext.Current["CurrentDriver"] as RemoteWebDriver;
                _errorlog = ScenarioContext.Current["CurrentErrorlog"] as ArrayList;
                if (_driver != null) _driver.Quit();
                ScenarioContext.Current.Remove("CurrentDriver");
                ScenarioContext.Current.Remove("CurrentErrorlog");
                if (_errorlog.Count > 0)
                {
                    string errorstring = "";
                    foreach (object i in _errorlog)
                    {
                        errorstring = errorstring + " ";
                        throw new WebDriverException(errorstring);
                    }
                }
            }
            else
            {
                throw new WebDriverException("The driver instance doesn't exist");
            }


            if (ScenarioContext.Current.ContainsKey("ScenarioDriver"))
            {
                _driver = ScenarioContext.Current["SecondDriver"] as RemoteWebDriver;
                if (_driver != null) _driver.Quit();
                ScenarioContext.Current.Remove("SecondDriver");
            }
        }

       
        [BeforeScenario]
        public void BeforeScenario()
        {
            title = ScenarioContext.Current.ScenarioInfo.Title;
            //log.Info(title);
            tag = ScenarioContext.Current.ScenarioInfo.Tags[0];
            //log.Info(tag);

        }


        
        [AfterScenario]
        public void AfterScenario()
        {
            var testresult = "";
            if (ScenarioContext.Current.TestError != null)
            {
                testresult = "Fail";
            }
            else
            {
                testresult = "Pass";
            }



            Teardown();

            var single_line = ConfigurationManager.AppSettings["Os"] + ConfigurationManager.AppSettings["Browser"];
            LogEventInfo csvresult = new LogEventInfo(LogLevel.Info,log.Name,"log result");
            csvresult.Properties["buildnumber"] = title;
            csvresult.Properties["testid"] = tag;
            csvresult.Properties["testresult"] = testresult;
            csvresult.Properties["info"] =single_line;

            log.Log(csvresult);
               

        }
        
    }
}