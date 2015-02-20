//create by cynthia

//create by cynthia
//working in progress


'use strict';

var url1 = 'https://test.secure.myob.com/';
var urltax='http://qa5.addevcloudsites.myob.com/tax/edit/?client=4cccbc62-15b1-41e3-a9ed-0d93e7d05db2&duedate=2015-06-25';
var title ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';


var expect = require('chai').use(require('chai-as-promised')).expect;
//webdriverio = require('webdriverjs-angular');
var webdriverio = require('webdriverio');

describe('Login', function () {

  var client;

  before(function (done) {
    client = webdriverio.remote(require('../../../conf/webdriver-chrome.conf.js'));  // move this line to 00_local.uispec.js and export client global?
    client.init(done);
  });

  after(function (done) {
    client.end(done);
  });

  it('MYOB Account - Sign in', function (done) {
    var baseUrl = process.env.BASE_URL || + url1;
    client
      .url(url1)
      .getTitle(function(err, title) {
        console.log('Title was: ' + title);
        //expect(value).to.equal(title);
      })
      .setValue('#Username', uemail)
      .setValue('#Password', pw)
      .submitForm('#submit')
      .pause(3000)
      .end(done);
  });
});
