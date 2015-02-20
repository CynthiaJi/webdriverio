//create by cynthia
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg3.cjspec.js
/*
 online@OnlineTax-L1:~/webdriverio-test/AD-OnlineTax-AU-FBT-2015/spec/ui$ mocha loginpg003.cjspec.js

*/


'use strict';

//
// Set up form server and Selenium for local testing.
// Ignore this file when testing with externally deployed application and when using BrowserStack et al.
//

var Static = require('node-static'),
  http = require('http'),
  path = require('path'),
  portfinder = require('portfinder'),
  selenium = require('selenium-standalone');

var server,
  seleniumProcess;

before(function (done) {
  var file = new Static.Server(path.join(__dirname, '../../build/test'));
  server = http.createServer(function (req, res) {
    req.addListener('end', function () {
      file.serve(req, res);
    }).resume();
  }).listen(0, function (err) {
    if (err) { return done(err); }
    var port = global.serverPort = server.address().port;
    console.log('Static file server running on port %s', port);
    portfinder.getPort({
      port: 40001
    }, function (err, seleniumPort) {
      if (err) { return done(err); }
      selenium.start({
        version: '2.43.1',  // PhantomJS 1.9.8 doesn't support Selenium >= 2.44.0. Version also hardcoded in package.json postinstall script
        seleniumArgs: ['-port', seleniumPort]
      }, function (err, child) {
        if (err) { return done(err); }
        seleniumProcess = child;
        global.seleniumPort = seleniumPort;
        console.log('Selenium started on port %s', seleniumPort);
        done();
      });
    });
  });
});

after(function (done) {
  if (seleniumProcess) {
    try {
      seleniumProcess.kill();
    } catch (err) {
      console.error('Could not kill selenium process');
    }
  }
  if (server) {
    try {
      server.close(done);
    } catch (err) {
      console.error('Could not close static file server');
      done(err);
    }
  } else {
    done(new Error("Couldn't stop server as it wasn't running."));
  }
});



//$$$$$$$$$$$$$$$$$$



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
  it('Client', function (done) {
    client
      .url(urltax)
      .pause(mywait)
      .getTitle(function(err, title) {
          console.log('Title was: ' + title);
          assert(title === title2);
          return this.url();
        console.log('url was: ' + this.url());

        })
      .getText('a[href="/tasks"]', function(err, result){
        console.log(result);
        assert(true);
      })
      .click('i[class=icon-task-centre]')
      .pause(2000)
      .call(done);
  });
/*
 ok ✓ MYOB Account - Sign in (14019ms)
 Title was: Practice Online
 Tasks
 ok ✓ Client (6064ms)


 3 passing (31s)

 */

});

/*

 it('Tax', function (done) {
 client
 .url(urltax)
 .windowHandleMaximize()
 .click('link=Add New Form')
 .pause(80000)
 .setValue('id=client', 'label=Ashworth & Co')
 .click('css=button.btn.btn-success')
 .getText(('#Business Details'), function(err, text1){
 assert(text1== 'Business Details');
 })
 .call(done);
 });
 <i class="icon-task-centre" title="Tasks"></i>
 selenium.open('/tax/fbt');
 selenium.click('css=i.icon-tax');
 selenium.click('css=i.icon-clients');
 selenium.click('css=i.icon-tax');
 selenium.open('/ledgers');
 selenium.click('link=Tasks');
 selenium.click('link=Tax');
 selenium.click('link=Add New Form');
 assertEquals('Business Details', selenium.getText('link=Business Details'));
 for (int second = 0;; second++) {
 if (second >= 60) fail('timeout');
 try { if ('2015 Fringe Benefits Tax Return'.equals(selenium.getText('css=h2.ng-binding'))) break; } catch (Exception e) {}
 Thread.sleep(1000);
 browser.open('/tax/fbt');
 browser.click('css=i.icon-tax');
 browser.click('css=i.icon-clients');
 browser.click('css=i.icon-tax');
 browser.open('/ledgers');
 browser.click('link=Tasks');
 browser.click('link=Tax');
 browser.click('link=Add New Form');
 browser.waitForFrameToLoad('', '');
 for (int second = 0;; second++) {
 if (second >= 60) fail('timeout');
 try { if ('Add FBT Return'.equals(browser.getText('css=h2'))) break; } catch (Exception e) {}
 Thread.sleep(1000);
 }

 for (int second = 0;; second++) {
 if (second >= 60) fail('timeout');
 try { if ('Select client'.equals(browser.getText('css=label'))) break; } catch (Exception e) {}
 Thread.sleep(1000);
 }

 browser.select('id=client', 'label=ABC Family Trust');
 browser.click('css=option[value=\'0\']');
 browser.select('id=client', 'label=Apple Orchard Holdings');
 browser.select('id=client', 'label=Ashworth & Co');
 browser.select('id=client', 'label=Mr Neville Bolt');
 for (int second = 0;; second++) {
 if (second >= 60) fail('timeout');
 try { if ('Create Return'.equals(browser.getText('css=button.btn.btn-success'))) break; } catch (Exception e) {}
 Thread.sleep(1000);
 }

 browser.click('css=button.btn.btn-success');
 assertEquals('Business Details', browser.getText('link=Business Details'));
 for (int second = 0;; second++) {
 if (second >= 60) fail('timeout');
 try { if ('2015 Fringe Benefits Tax Return'.equals(browser.getText('css=h2.ng-binding'))) break; } catch (Exception e) {}
 Thread.sleep(1000);
 }

 */
