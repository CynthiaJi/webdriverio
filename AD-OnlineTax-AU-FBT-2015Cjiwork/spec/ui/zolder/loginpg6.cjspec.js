//create by cynthia
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg3.cjspec.js
/*
working in progress - line 168

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

  var client;

  before(function (done) {
    client = webdriverio.remote(require('../../../conf/webdriver-chrome.conf.js'));  // move this line to 00_local.uispec.js and export client global?
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

  it('Client', function (done) {
    client
      .url(urltax)
      .getTitle(function(err, title) {
          console.log('Title was: ' + title);
          assert(title === title2);
          return this.url();
        })
      .getText('a[href="/tasks"]', function(err, result){
        console.log(result);
        assert(true);
      })
      .nextElementSibling('page-loading',function(err,res){
        console.log(res.id);
      })
      .click('i[class=icon-task-centre]')
      .pause(2000)
      .call(done);
  });

});

/*



 */
