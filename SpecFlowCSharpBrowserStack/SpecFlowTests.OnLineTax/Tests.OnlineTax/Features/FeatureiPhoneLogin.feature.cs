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
namespace SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("FeatureiPhoneLogin", Description="OnLineTaxLoginMobile - iPhone", SourceFile="Features\\FeatureiPhoneLogin.feature", SourceLine=0)]
    public partial class FeatureiPhoneLoginFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureiPhoneLogin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureiPhoneLogin", "OnLineTaxLoginMobile - iPhone", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TSuite978IPhone(string mybrowser, string username, string password, string mytitle, string mytitle2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC978"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TSuite978iPhone", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("Navigate to the OnLineTax  Homepage with title {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When(string.Format("Login with {0}  Password  {1}  page tile  {2}", username, password, mytitle2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("Logout   {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TSuite978iPhone, \"iPadSafari_61\"", new string[] {
                "TC978"}, SourceLine=13)]
        public virtual void TSuite978IPhone_IPadSafari_61()
        {
            this.TSuite978IPhone("\"iPadSafari_61\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TSuite978iPhone, \"iPadSafari_70\"", new string[] {
                "TC978"}, SourceLine=14)]
        public virtual void TSuite978IPhone_IPadSafari_70()
        {
            this.TSuite978IPhone("\"iPadSafari_70\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TSuite978iPhone, \"iPhone61Safari_5\"", new string[] {
                "TC978"}, SourceLine=15)]
        public virtual void TSuite978IPhone_IPhone61Safari_5()
        {
            this.TSuite978IPhone("\"iPhone61Safari_5\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TSuite978iPhone, \"iPhone70Safari_5C\"", new string[] {
                "TC978"}, SourceLine=16)]
        public virtual void TSuite978IPhone_IPhone70Safari_5C()
        {
            this.TSuite978IPhone("\"iPhone70Safari_5C\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TSuite978iPhone, \"iPhone70Safari_5S\"", new string[] {
                "TC978"}, SourceLine=17)]
        public virtual void TSuite978IPhone_IPhone70Safari_5S()
        {
            this.TSuite978IPhone("\"iPhone70Safari_5S\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
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
    [NUnit.Framework.DescriptionAttribute("FeatureiPhoneLogin")]
    public partial class FeatureiPhoneLoginFeature_NUnit
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureiPhoneLogin.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureiPhoneLogin", "OnLineTaxLoginMobile - iPhone", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("TSuite978iPhone")]
        [NUnit.Framework.CategoryAttribute("TC978")]
        [NUnit.Framework.TestCaseAttribute("\"iPadSafari_61\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"iPadSafari_70\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"iPhone61Safari_5\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"iPhone70Safari_5C\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"iPhone70Safari_5S\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        public virtual void TSuite978IPhone(string mybrowser, string username, string password, string mytitle, string mytitle2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC978"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TSuite978iPhone", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("Navigate to the OnLineTax  Homepage with title {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When(string.Format("Login with {0}  Password  {1}  page tile  {2}", username, password, mytitle2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("Logout   {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
