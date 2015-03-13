using System;
using System.Configuration;
using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;


 

namespace SpecFlow.Specs.StepDefinitions.TestCases
{

    public class BaseCases
    {
        protected RemoteWebDriver Driver;
        protected ArrayList Errorlog = new ArrayList();
        ChromeOptions options = new ChromeOptions();

        //StepDefinitions\DriverServices
        public BaseCases()
        {
            if (!ScenarioContext.Current.ContainsKey("CurrentDriver"))
            {
                var serverUrl = ConfigurationManager.AppSettings["ServerUrl"];
                var capability = new DesiredCapabilities();
                var runningServer = ConfigurationManager.AppSettings["RunningServer"];
                var browser = ConfigurationManager.AppSettings["Browser"];

                if (runningServer == "Local") { capability.SetCapability("browserstack.local", "true"); }
               
                switch (browser)
                {
                    case "IE11os70r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie11"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;

                    case "IE10os70r10":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution10"]);
                        break;

                    case "IE09os70r11":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie90"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;

                    case "IE10os80r10":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution10"]);
                        break;

                   

                    case "GC360os81r01":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC360"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "GC350os80r08":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC350"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "GC340os70r11":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC340"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;
                    case "IE11os81r01":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie11"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "IE10os80r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "IE090os80r11":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "FF310os81r01":

                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff310"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "FF300os80r08":
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff300"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "FF290os70r11":
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff290"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;

                    case "FF310os80r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff310"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;


                    case "Opera1216os81r01":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1216"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "Opera1216os80r08":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1216"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "Opera1215os70r11":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1215"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;

                    case "Safari51os81r01":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "Safari51os80r08":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "Safari51os70r10":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution10"]);
                        break;

                    //mobile
                    case "iPhone70_5C":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5C"]);
                        break;
                    case "iPhone70_5S":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5S"]);
                        break;
                    case "iPhone61_5":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5"]);
                        break;  
                //Tablet
                    case "iPad_70":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPad"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_iPadmini"]);
                        break;
                    case "iPad_61":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPad"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_iPad4th"]);
                        break;  
                    //Android Mobile
                       case "android42M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M42"]);
                        break;
                    case "android41M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M41"]);
                        break;
                    case "android40M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M40"]);
                        break;
                    case "android41Tablet":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_T41"]);
                        break;
                    case "android40Tablet":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_T40"]);
                        break;
                    default:
                                capability = DesiredCapabilities.Firefox();
                                break;
                        }
                    

                        //capability.SetCapability("build", "screenshot test");
                // Debugging is set to false by default.
                        capability.SetCapability("browserstack.debug", "true");
                        capability.SetCapability("browserstack.user",
                        ConfigurationManager.AppSettings["BrowserStackuname"] );

                        //To avoid invalid certificate errors while testing on BrowserStack Automate, set the acceptSslCerts capability in your test to true.
                        capability.SetCapability("browserstack.key", ConfigurationManager.AppSettings["BrowserStackaccesskey"]);
                        capability.SetCapability("acceptSslCerts", "true");
                    
                

                //Driver = new OpenQA.Selenium.Remote.RemoteWebDriver(new Uri(serverUrl), capability);
                Driver = new RemoteWebDriver(new Uri(serverUrl), capability);

                Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
                ScenarioContext.Current.Add("CurrentDriver", Driver);
                ScenarioContext.Current.Add("CurrentErrorlog", Errorlog);
            }
            else
            {
                Driver = ScenarioContext.Current["CurrentDriver"] as OpenQA.Selenium.Remote.RemoteWebDriver;
                Errorlog = ScenarioContext.Current["CurrentErrorlog"] as ArrayList;
            }
        }


        //This method is used to create the 2nd driver instance in the same test case instance
        public RemoteWebDriver CreateNewDriver()
        {
            var serverUrl = ConfigurationManager.AppSettings["ServerUrl"];
            var capability = new DesiredCapabilities();
            var runningServer = ConfigurationManager.AppSettings["RunningServer"];
            var browser = ConfigurationManager.AppSettings["Browser"];

            switch (browser)
            {
                case "IE11os70r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie11"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;

                    case "IE10os70r10":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution10"]);
                        break;

                    case "IE09os70r11":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie90"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;

                    case "IE10os80r10":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution10"]);
                        break;

                   

                    case "GC360os81r01":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC360"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "GC350os80r08":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC350"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "GC340os70r11":
                        capability.SetCapability("browser", "Chrome");
                        //capability.SetCapability("browser_version", "36.0");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_GC340"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;
                    case "IE11os81r01":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie11"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "IE10os80r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "IE090os80r11":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "IE");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_ie10"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "FF310os81r01":

                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff310"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "FF300os80r08":
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff300"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "FF290os70r11":
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff290"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;

                    case "FF310os80r08":
                        capability = DesiredCapabilities.InternetExplorer();
                        capability.SetCapability("browser", "Firefox");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["Browser_ff310"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;


                    case "Opera1216os81r01":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1216"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "Opera1216os80r08":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1216"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "Opera1215os70r11":
                        capability.SetCapability("browser", "Opera");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_Opera1215"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;

                    case "Safari51os81r01":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_81"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution01"]);
                        break;
                    case "Safari51os80r08":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_80"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution08"]);
                        break;
                    case "Safari51os70r10":
                        capability.SetCapability("browser", "Safari");
                        capability.SetCapability("browser_version", ConfigurationManager.AppSettings["browser_safari51"]);
                        capability.SetCapability("os", ConfigurationManager.AppSettings["os_w"]);
                        capability.SetCapability("os_version", ConfigurationManager.AppSettings["os_70"]);
                        capability.SetCapability("resolution", ConfigurationManager.AppSettings["resolution11"]);
                        break;

                    //mobile
                    case "iPhone70_5C":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5C"]);
                        break;
                    case "iPhone70_5S":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5S"]);
                        break;
                    case "iPhone61_5":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPhone"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_5"]);
                        break;  
                //Tablet
                    case "iPad_70":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPad"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_iPadmini"]);
                        break;
                    case "iPad_61":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_iPad"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_MAC"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_iPad4th"]);
                        break;  
//Android Mobile
                    case "android42M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M42"]);
                        break;
                    case "android41M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M41"]);
                        break;
                    case "android40M":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_M40"]);
                        break;
                    case "android41Tablet":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_T41"]);
                        break;
                    case "android40Tablet":
                        capability.SetCapability("browserName", ConfigurationManager.AppSettings["browser_android"]);
                        capability.SetCapability("platform", ConfigurationManager.AppSettings["platform_Android"]);
                        capability.SetCapability("device", ConfigurationManager.AppSettings["device_T40"]);
                        break;
                    default:
                                capability = DesiredCapabilities.Firefox();
                                break;
                       
                    
            }

            var driver = new OpenQA.Selenium.Remote.RemoteWebDriver(
                   new Uri(serverUrl), capability
                   );
            ScenarioContext.Current.Add("SecondDriver", driver);
            return driver;
        }
    }

}



/*
 *  //Selenium Server
                //https://code.google.com/p/selenium/wiki/Grid2

                //IE
                //http://stackoverflow.com/questions/8837875/setting-remote-webdriver-to-run-tests-in-a-remote-computer-using-java

                //Chrome
                //https://code.google.com/p/selenium/wiki/ChromeDriver#Overriding_the_Chrome_binary_location
                //http://stackoverflow.com/questions/15199545/remote-webdriver-chrome-throws-a-path-to-the-driver-executable-error
 * 
                    case "Firefox":
                                capability = DesiredCapabilities.Firefox();
                                break;
                    case "Chrome":
                                capability = DesiredCapabilities.Chrome();
                                //add below line by Cji
                                //ChromeOptions options = new ChromeOptions();
                                //options.setBinary("/path/to/other/chrome/binary");
                                options = new ChromeOptions();
                                options.BinaryLocation = "C://Selenium-Server/chromedriver.exe";
                                capability.SetCapability(ChromeOptions.Capability, options);
                                break;
                    case "Opera":
                                capability = DesiredCapabilities.Opera();
                                break;
 * **/



