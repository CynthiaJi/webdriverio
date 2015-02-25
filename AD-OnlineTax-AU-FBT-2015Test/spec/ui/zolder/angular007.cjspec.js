//create by cynthia
//mocha --slow 15000 --timeout 30000 --recursive spec/**/loginpg3.cjspec.js
/*


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


 var webdriverioj = require('webdriverjs-angular');




describe('TaxOnlineTest', function () {

  //var client;
  this.timeout(99999999);
  var client = {};



    client = webdriverioj.remote({ desiredCapabilities: {browserName: 'firefox'} });



  var baseUrl = process.env.BASE_URL || +url1;

  it('SecurityPage', function (done) {

    client
      .init(done)
      .url('http://www.google.com')
      .title(function (err, res) {
        console.log('Title was: ' + res.value);
      })
      .call(done);
  });
  });

/**
 1) TaxOnlineTest SecurityPage:
 Uncaught RuntimeError
 (ScriptTimeout:28) A script did not complete before its timeout expired.
 Problem: Timed out waiting for async script result after 10001ms
 Build info: version: '2.44.0', revision: '76d78cf', time: '2014-10-23 20:02:37'
 System info: host: 'OnlineTax-L1', ip: '127.0.1.1', os.name: 'Linux', os.arch: 'amd64', os.version: '3.13.0-43-generic', java.version: '1.7.0_65'
 Driver info: driver.version: unknown

 Callstack:
 -> executeAsync([Function],[20])
 -> url("http://www.google.com")
 -> url("http://www.google.com")

*/
