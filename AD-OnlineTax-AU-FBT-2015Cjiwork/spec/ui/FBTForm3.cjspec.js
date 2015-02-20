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
  it('Smoke - Tasks', function (done) {
    client
      .click('a[href="/tasks"]')
      .getText('a[href="/tasks"]', function(err, result){
        console.log(result);
        assert(result === 'Tasks');
      })
      .pause(mywait)
      .call(done);
  })
  it('Smoke - Accounting', function (done) {
    client
      .click('a[href="/ledgers"]')
      .getText('a[href="/ledgers"]', function(err, result){
        console.log(result);
        assert(result === 'Accounting');
      })
      .pause(mywait)
      .call(done);
  })
  it('Smoke - Documents', function (done) {
    client
      .click('a[href="/documents"]')
      .getText('a[href="/documents"]', function(err, result){
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
      .click('[class="icon-tax"]') // click on %Tax icon on the task bar
      .pause(mywait)
      .click('[class="page-header-cta btn btn-success"]') //Click on Add new form
      .pause(mywait)
      .getText('[class="page-header ng-scope"]', function(err, result) {
        console.log(result);
        assert(result === 'Add FBT Return');
        //Add FBT Return
      })
      .pause(mywait)
      .call(done);
  });

  it('Tax - Create FBT Return', function (done) {
    client
      .selectByValue('#client', '2') //Select the Client from the select client
      .pause (mywait)
      .getText('[class="btn btn-success"]', function(err, result) {
        console.log(result);
        assert(result === 'Create Return')
        //assert(result === 'Create Return');
        //Add FBT Return

      })
      .click('[class="btn btn-success"]') //Click on Create Return
      .pause(mywait)
      .call(done);
  })

});






/**
 ok ✓ MYOB Account - Sign in (13406ms)
 Tasks
 ok ✓ Smoke - Tasks (3450ms)
 Accounting
 ok ✓ Smoke - Accounting (3485ms)
 Documents
 ok ✓ Smoke - Documents (3761ms)
 Add FBT Return
 ok ✓ Tax - Add FBT Return (9341ms)
 Create Return
 ok ✓ Tax - Create FBT Return (6495ms)
 successfully entered the TFN
 successfully entered the ABN
 successfully entered the data of the business details tab


 */
