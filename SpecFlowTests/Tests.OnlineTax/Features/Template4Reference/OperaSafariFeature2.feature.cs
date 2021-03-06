﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Specs.Features.Template4Reference
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("SafariFeature", Description="In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
        "wo numbers", SourceFile="Features\\Template4Reference\\OperaSafariFeature.feature", SourceLine=0)]
    public partial class SafariFeatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OperaSafariFeature.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SafariFeature", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void TS060101Safari(string mybrowser, string googleHome, string myword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC060101"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS060101Safari", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("Navigate to Google Homepage {0}", googleHome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And(string.Format("search the word {0}", myword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then(string.Format("Assert that page tile include {0}", myword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS060101Safari, \"Safari51os81r01\"", new string[] {
                "TC060101"}, SourceLine=16)]
        public virtual void TS060101Safari_Safari51Os81R01()
        {
            this.TS060101Safari("\"Safari51os81r01\"", "\"http://www.google.com.au\"", "\"Test IE09\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS060101Safari, \"Safari51os80r08\"", new string[] {
                "TC060101"}, SourceLine=17)]
        public virtual void TS060101Safari_Safari51Os80R08()
        {
            this.TS060101Safari("\"Safari51os80r08\"", "\"http://www.google.com.au\"", "\"MYOB IE11\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS060101Safari, \"Safari51os70r10\"", new string[] {
                "TC060101"}, SourceLine=18)]
        public virtual void TS060101Safari_Safari51Os70R10()
        {
            this.TS060101Safari("\"Safari51os70r10\"", "\"http://www.google.com.au\"", "\"Browser IE10\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SafariFeature")]
    public partial class SafariFeatureFeature_NUnit
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OperaSafariFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SafariFeature", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TS060101Safari")]
        [NUnit.Framework.CategoryAttribute("TC060101")]
        [NUnit.Framework.TestCaseAttribute("\"Safari51os81r01\"", "\"http://www.google.com.au\"", "\"Test IE09\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"Safari51os80r08\"", "\"http://www.google.com.au\"", "\"MYOB IE11\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"Safari51os70r10\"", "\"http://www.google.com.au\"", "\"Browser IE10\"", null)]
        public virtual void TS060101Safari(string mybrowser, string googleHome, string myword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC060101"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS060101Safari", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("Navigate to Google Homepage {0}", googleHome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And(string.Format("search the word {0}", myword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then(string.Format("Assert that page tile include {0}", myword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
