//create by cynthia
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg3.cjspec.js
/*
 online@OnlineTax-L1:~/webdriverio-test/AD-OnlineTax-AU-FBT-2015/spec/ui$ mocha loginpg003.cjspec.js
 first run java stand alone server
 Aonline@OnlineTax-L1:~/webdriverio-test$
 java -jar selenium-server-standalone4.0.jar



 then run the test
 mocha loginpg007.cjspec.js
This test combine Preethi and Cynthia - working fine

 */


'use strict';



var url0 = 'https://test.secure.myob.com/';
var url1='http://qa5.addevcloudsites.myob.com';

var url2= url1+'/clients';
//url1+'/clients/portals';
var urltax= url1+ '/tax/fbt';
var urltax2 = url1 + '/tax/edit/?client=4cccbc62-15b1-41e3-a9ed-0d93e7d05db2&duedate=2015-06-25';

var title0 ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';
var  title2 ='Practice Online';
var mywait = 3000;

var expect = require('chai').expect;
var assertions = require('mocha').it;
var assert = require('assert');


  //webdriverio = require('webdriverjs-angular');


var webdriverio = require('webdriverio');

describe('TaxOnlineTest', function () {

  //var client;
  this.timeout(99999999);
  var client = {};


  before(function(done){
    //client = webdriverio.remote(require('../../conf/webdriver-chrome.conf'));
    client = webdriverio.remote({ desiredCapabilities: {browserName: 'firefox'} });
    client.init(done);
  });
  after(function (done) {
    client.end(done);
  });


  var baseUrl = process.env.BASE_URL || +url1;

  it('SecurityPage', function (done) {

    client
      .url(url1)
      .pause(mywait)
      .getTitle().then(function (title) {
        console.log('Title was: ' + title);
        assert(title === title0);
        return this.url();
      })
      .call(done);
  })
/*
 TaxOnlineTest
 Title was: MYOB Account - Sign in
 ok ✓ SecurityPage (6667ms)

 */

  it('MYOB Account - Sign in', function (done) {

    client
      .windowHandleMaximize()
      .setValue('#Username', uemail)
      .setValue('#Password', pw)
      .submitForm('#submit')
      .pause(mywait)
      .getTitle().then(function(title) {
        console.log('Title was: ' + title);
        assert(title === title2);
        console.log('URL was: ' + this.url);
        return this.url();
      })
      .pause(mywait)
      .call(done);
  });
/*
 Title was: Practice Online
 ok ✓ MYOB Account - Sign in (11467ms)

 */



  it('Tax', function (done) {
    client
      .click('[class="icon-tax"]') // click on %Tax icon on the task bar
      .pause(2000)
      .click('[class="page-header-cta btn btn-success"]') //Click on Add new form
      .pause(2000)
      .getText('[class="page-header ng-scope"]', function(err, text) {
        console.log(text);
      })
      .pause(2000)
      .selectByValue('#client', '0') //Select the Client from the select client
      .pause (1000)
      .click('[class="btn btn-success"]') //Click on Create Return
      .pause (3000)

// Enter the details on the Business details tab

      .frame('iFrameResizer0') //Identifying the frame
      .setValue('[ng-model="form.fields[\'ReportingParty.Identifiers.TaxFileNumber.Identifier\'].value"]', '999999523') //enter the TFN
      .pause (1000)
      .getValue('[ng-model="form.fields[\'ReportingParty.Identifiers.TaxFileNumber.Identifier\'].value"]')
      .then(function (value) {
        console.log('successfully entered the TFN');
      })

      .setValue('[ng-model="form.fields[\'ReportingParty.Identifiers.AustralianBusinessNumber.Identifier\'].value"]', '98111133334') //Enter the ABN
      .pause (1000)
      .getValue('[ng-model="form.fields[\'ReportingParty.Identifiers.AustralianBusinessNumber.Identifier\'].value"]')
      .then(function (value) {
        console.log('successfully entered the ABN');
      })
      .pause (1000)
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.TrusteeSeniorPartner.Required\'].value"]', 'true') //Select the employer a trust or partnership?
      .pause (1000)
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.TrusteeSeniorPartner.IndividualOrNonIndividual\'].value"]', 'Non-individual') //Select trustee or senior partner individual and non individual
      .pause (1000)
      .setValue('[id="input.ReportingParty.TrusteeSeniorPartner.OrganisationNameDetails.OrganisationalName.Text"]','trustee or senior partner')
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.Employer.IndividualOrNonIndividual\'].value"]', 'Non-individual') //Select the employer an individual or non-individual

      .setValue('[id="input.ReportingParty.Employer.Postal.AddressDetails.Line1.Text"]','84 Joadja road') //Enter Addressline1
      .setValue('[id="input.ReportingParty.Employer.Postal.AddressDetails.Line2.Text"]','AddressLine2')//Enter Addressline2
      .setValue('[id="input.ReportingParty.Employer.Postal.AddressDetails.Line4.Text"]','AddressLine4')//Enter Addressline4
      .setValue('[id="input.ReportingParty.Employer.Postal.AddressDetails.LocalityName.Text"]','Melbourne') // Enter the town
      .selectByValue('[ng-model="form.fields[\'ReportingParty.Employer.Postal.AddressDetails.StateOrTerritory.Code\'].value"]', 'VIC') //Select the state
      .setValue('[id="input.ReportingParty.Employer.Postal.AddressDetails.Postcode.Text"]','3000') //Enter the Postal code
      // .selectByValue('[ng-model="form.fields[\'ReportingParty.Employer.Postal.AddressDetails.Country.Code\'].value"]', 'AL') //Select country outside Australia
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.Employer.Previous.Name.Required\'].value"]', 'false') //Select employer name changed
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.Employer.Previous.Required\'].value"]', 'false') //Select postal address changed
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.BusinessTradingName.Required\'].value"]', 'false') //Select Business/trading name changed first FBT
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.BusinessTradingAddress.Required\'].value"]', 'false') //Select Business/trading address changed first FBT
      .selectByValue('[ng-model="form.fields[\'Myob.ReportingParty.TrusteeSeniorPartner.Previous.Required\'].value"]', 'true') //Select trustee/senior partner

// Name of the person to contact

      //  .selectByValue('[ng-model="form.fields[\'ReportingParty.Contact.Title.Text\'].value"]', 'MR') //Select title

      .setValue('[id="input.ReportingParty.Contact.GivenName.Text"]','First given name') //Enter the given name
      .setValue('[id="input.ReportingParty.Contact.OtherGivenName.Text"]','other given name') //Enter the other given name
      .setValue('[id="input.ReportingParty.Contact.FamilyName.Text"]','Family Name') //Enter the other given name
      .selectByValue('[ng-model="form.fields[\'ReportingParty.Contact.NameSuffix.Text\'].value"]', 'ESQ') //Select the Suffix
      .setValue('[id="input.ReportingParty.ElectronicContact.Telephone.Area.Code"]','1234') //Enter the Area code
      .setValue('[id="input.ReportingParty.ElectronicContact.Telephone.Minimal.Number"]','0465124987') //Enter the Phone number
      .setValue('[id="input.ReportingParty.ElectronicContact.ElectronicMail.Address.Text"]','abcfamily@testonly.com') //Enter the email address
      .setValue('[id="input.ReportingParty.Remuneration.FringeBenefits.Recipients.Count"]','2') //Enter the number of employees receiving FB
      .setValue('[id="input.ReportingParty.Report.CompletionHours.Number"]','1') //Enter the hours taken to complete this form
      .selectByValue('[ng-model="form.fields[\'ReportingParty.Lodgment.FinalReturn.Indicator\'].value"]', 'true') //Select expect to lodge FBT return this year
      .setValue('[id="input.ReportingParty.FinancialInstitutionAccount.BankStateBranch.Number"]','013000') //Enter the Bank state branch
      .setValue('[id="input.ReportingParty.FinancialInstitutionAccount.FinancialInstitutionAccount.Number"]','123456789') //Enter the Bank state branch
      .setValue('[id="input.ReportingParty.FinancialInstitutionAccount.FinancialInstitutionAccountName.Text"]','Account Name') //Enter the Account Name
      .getValue('[id="input.ReportingParty.FinancialInstitutionAccount.FinancialInstitutionAccountName.Text"]')
      .then(function (value) {
        console.log('successfully entered the data of the business details tab');
      })
      .end();
  });

});






/**
 ✓ MYOB Account - Sign in (9886ms)
 Add FBT Return
 successfully entered the TFN
 successfully entered the ABN
 successfully entered the data of the business details tab

 */
