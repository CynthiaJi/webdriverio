//create by cynthia

//create by cynthia
//working in progress
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg2.cjspec.js
/*
 loginpg2.cjspec.js

 Static file server running on port 38074
 Selenium started on port 40001
 Tax online test
 Title was: MYOB Account - Sign in
 '✓ security page
 Title was: Practice Online
 '✓ MYOB Account - Sign in (7784ms)
 Title was: Practice Online
 '✓ tax on line browse

 all 3 passing (18s)

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

//var chai = require('chai');
var expect = require('chai').expect;
var assertions = require('mocha').it
var assert = require('assert')

//var  chai-as-promised=require('chai-as-promised');
//var expect = require('chai').use(require('chai-as-promised')).expect;
//webdriverio = require('webdriverjs-angular');


var webdriverio = require('webdriverio');
var webdriverjs =require('webdriverjs-angular');
describe('Tax online test', function () {

  var client;
  var client2 ;


  before(function (done) {
    client = webdriverio.remote(require('../../../conf/webdriver-chrome.conf.js'));  // move this line to 00_local.uispec.js and export client global?
    client.init(done);
    client2 = webdriverjs.remote(require('../../../conf/webdriver-chrome.conf.js'));
    client2.init(done);
  });

  after(function (done) {
    client.end(done);
  });


  var baseUrl = process.env.BASE_URL || +url1;

  it('security page', function (done) {

    client
      .url(url1)
      .pause(2000)
      .getTitle().then(function (title) {
        console.log('Title was: ' + title);
        assert(title === title0);
        return this.url();
      })
      .call(done);
  })


  it('MYOB Account - Sign in', function (done) {

    client
      .setValue('#Username', uemail)
      .setValue('#Password', pw)
      .submitForm('#submit')
      .pause(3000)
      .getTitle().then(function(title) {
        console.log('Title was: ' + title);
        assert(title === title2);
        return this.url();
      })
      .call(done);
  });

  it('tax', function (done) {
    client2
      .url(urltax)
      .getTitle(function(err, title) {
        console.log('Title was: ' + title);
        assert(title === title2);
        return this.url();
      })
      .end(done);
  });


it('Client', function (done) {
    client2
      .url(urltax)
      .getTitle(function(err, title) {
        console.log('Title was: ' + title);
        assert(title === title2);
        return this.url();
      })
      .click('=Clients', function(err, res) {
        console.log('text was: ' + client.getText('=Clients'));
        assert(client.getText('=Clients') == 'Clients');
      })
      .pause(2000)
      .call(done);
  });

  it('Accounting', function (done) {
    client2
      .click('=Accounting', function(err, text) {
        console.log('text was: ' + text);
        assert(text == 'Accounting');
      })
      .pause(2000)
      .call(done);
  });

  it('Tax', function (done) {
    client2
      .url(urltax)
      .getTitle(function(err, title) {
        console.log('Title was: ' + title);
        assert(title === title2);
        return this.url();
      })
      .end(done);
  });
});

