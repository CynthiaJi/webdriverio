//create by cynthia




'use strict';



var url0 = 'https://test.secure.myob.com/';
var url1='http://qa5.addevcloudsites.myob.com';

var url2= url1+'/clients';
//url1+'/clients/portals';
var urltax= url1+ '/tax/fbt';


var title0 ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';
var  title2 ='Practice Online';
var mywait = 0;

var expect = require('chai').expect;
var assertions = require('mocha').it;
var assert = require('assert');

//data tax file number
var mytfn01 ='128383836';
var mytfn02 ='999999558';
var mytfn03 ='999999566';
var mytfn04 ='999999574';
var mytfn05 ='121231537';
var mytfn06 ='112432335';
var mytfn07 ='141125165';
var mytfn08 ='212231186';
var mytfn09 ='111154144';
var mytfn10 ='321131236';


//data abn
var myabn01 = '78928626495';
var myabn02 = '111235114';
var myabn03 = '999999507';
var myabn04 = '999999523';
var myabn05 = '84111122223';
var myabn06 = '98111133334';
var myabn07 = '23111144445';
var myabn08 = '37111155556';
var myabn09 = '51111166667';

//webdriverio = require('webdriverjs-angular');


var webdriverio = require('webdriverjs-angular');

describe('TaxOnlineTest', function () {

  //var client;
  this.timeout(99999999);
  var client = {};


  before(function (done) {
    //client = webdriverio.remote(require('../../conf/webdriver-chrome.conf'));
    client = webdriverio.remote({desiredCapabilities: {browserName: 'firefox'}});
    client.init(done);
  });
  after(function (done) {
    client.end(done);
  });


  var baseUrl = process.env.BASE_URL || +url1;

  it('SecurityPage', function (done) {

    client
      .withoutAngular()
      .url(url1)
      .pause(mywait)
      .getTitle().then(function (title) {
        console.log('Title was: ' + title);
        assert(title === title0);
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
      .withoutAngular()
      .windowHandleMaximize()
      .setValue('#Username', uemail)
      .setValue('#Password', pw)
      .submitForm('#submit')
      .pause(mywait)
      .getTitle().then(function (title) {
        console.log('Title was: ' + title);
        assert(title === title2);
      })
      .pause(mywait)
      .call(done);
  });
  /*
   Title was: Practice Online
   ok ✓ MYOB Account - Sign in (11467ms)

   */
  xit('Smoke - Tasks', function (done) {
    client
      .withAngular()
      .click('a[href="/tasks"]')
      .getText('a[href="/tasks"]', function (err, result) {
        console.log(result);
        assert(result === 'Tasks');
      })
      .pause(mywait)
      .call(done);
  })
  xit('Smoke - Accounting', function (done) {
    client
      .withAngular()
      .click('a[href="/ledgers"]')
      .getText('a[href="/ledgers"]', function (err, result) {
        console.log(result);
        assert(result === 'Accounting');
      })
      .pause(mywait)
      .call(done);
  })
  xit('Smoke - Documents', function (done) {
    client
      .withAngular()
      .click('a[href="/documents"]')
      .getText('a[href="/documents"]', function (err, result) {
        console.log(result);
        assert(result === 'Documents');
      })

      .pause(mywait)
      .call(done);
  });

  /**
   * documentsTasks
   Accounting
   Documents
   ok ✓ Smoke (3562ms)


   */


  it('Tax - Add FBT Return', function (done) {
    client
      .withAngular()
      .click('[class="icon-tax"]') // click on %Tax icon on the task bar
      .pause(mywait)
      .click('[class="page-header-cta btn btn-success"]') //Click on Add new form
      .pause(mywait)
      .getText('[class="page-header ng-scope"]', function (err, result) {
        console.log(result);
        assert(result === 'Add FBT Return');
        //Add FBT Return
      })
      .pause(mywait)
      .call(done);
  });

  it('Tax - Create FBT Return', function (done) {
    client
      .waitFor('//select[@id="client"]/option[text()="Please select"]', 5000)
      .selectByValue('#client', '2') //Select the Client from the select client
      .pause(mywait)
      .getText('[class="btn btn-success"]', function (err, result) {
        console.log(result);
        assert(result === 'Create Return')
        //assert(result === 'Create Return');
        //Add FBT Return

      })
      .click('[class="btn btn-success"]') //Click on Create Return
      .pause(mywait)
      .call(done);
  })
  //

  // Enter the details on the Business details tab

  it('Tax - FBT Item TFN', function (done) {
    client
      .frame('iFrameResizer0') //Identifying the frame
      .setValue('[ng-model="form.fields[\'ReportingParty.Identifiers.TaxFileNumber.Identifier\'].value"]', mytfn01) //enter the TFN
      .click('[ng-click="save(form)"]')
      .pause(mywait)
      .getValue('[ng-model="form.fields[\'ReportingParty.Identifiers.TaxFileNumber.Identifier\'].value"]',function(err, value){
        console.log(value);
        assert(value === mytfn01);
      })
        .pause(mywait)
        .call(done);
  })

  it('Tax - FBT Item ABN', function (done) {
    client
      .setValue('[ng-model="form.fields[\'ReportingParty.Identifiers.AustralianBusinessNumber.Identifier\'].value"]', myabn01) //Enter the ABN
      .pause(mywait)
      .click('[ng-click="save(form)"]')
      .getValue('[ng-model="form.fields[\'ReportingParty.Identifiers.AustralianBusinessNumber.Identifier\'].value"]', function(err, value){
        console.log(value);
        assert(value === myabn01);
      })
      .pause(mywait)
      .call(done);
  })

})
/**
 .click('#Return Calculation Details')
 online@OnlineTax-L1:~/webdriverio-test/AD-OnlineTax-AU-FBT-2015/spec/ui$ mocha FBTitem14.js


 TaxOnlineTest
 Title was: MYOB Account - Sign in
 ok ✓ SecurityPage (4244ms)
 Title was: Practice Online
 ok ✓ MYOB Account - Sign in (4273ms)
 - Smoke - Tasks
 - Smoke - Accounting
 - Smoke - Documents
 Add FBT Return
 ok ✓ Tax - Add FBT Return (19923ms)
 Create Return
 ok ✓ Tax - Create FBT Return (28967ms)
 128383836
 ok ✓ Tax - FBT Item TFN (14888ms)
 78928626495
 ok ✓ Tax - FBT Item ABN (6881ms)


 ###Add FBT Return
 ok ✓ Tax - Add FBT Return (18070ms)
 Create Return
 ok ✓ Tax - Create FBT Return (31198ms)
 128383836
 ok ✓ Tax - FBT Item TFN (13421ms)
 78928626495
 ok ✓ Tax - FBT Item ABN (16150ms)



 6 passing (1m)
 3 pending

 online@OnlineTax-L1:~/webdriverio-test/AD-OnlineTax-AU-FBT-2015/spec/ui$
 it('Tax - FBT Form Saved', function (done) {
    client
      .click('[ng-click="save(form)"]')  //.click('[class="btn btn-success"]')
      .getValue('[class="ng-binding status"]', function(err, value){
        console.log(value);
        assert(value === 'Form saved');
      })
      .pause(mywait)
      .call(done);
  })
 */
