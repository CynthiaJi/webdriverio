//create by cynthia
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg3.cjspec.js
/*
 online@OnlineTax-L1:~/webdriverio-test/AD-OnlineTax-AU-FBT-2015/spec/ui$ mocha loginpg003.cjspec.js

*/


'use strict';


var url0 = 'https://test.secure.myob.com/';
var url1='http://qa5.addevcloudsites.myob.com';

var urltax= url1+ '/tax/fbt';


var title0 ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';
var  title2 ='Practice Online';
var mywait = 3000;



var expect = require('chai').expect;
var assertions = require('mocha').it;
var assert = require('assert');
var baseUrl = process.env.BASE_URL || +url1;



var webdriverjsAngular = require('webdriverjs-angular');

var options = {
  desiredCapabilities: {
    browserName: 'chrome'
  },
  ngRoot: 'body' // main application selector
};

describe('TaxOnlineTest', function () {
  it('should return the source code of the whole website', function(done) {
    webdriverjsAngular
      .remote(options)
      .init()
      .url('http://www.google.com')
      .title(function (err, res) {
        console.log('Title was: ' + res.value);
      })
      .end();
  });
})
