/**
 * Created by online on 4/02/15.
 */


var expect = require('chai').use(require('chai-as-promised')).expect;

var webdriverio = require('webdriverjs-angular');


var url1 = 'https://test.secure.myob.com/';
var baseUrl = 'http://qa5.addevcloudsites.myob.com/';
var urltax='http://qa5.addevcloudsites.myob.com/tax/fbt';

var title ='MYOB Account - Sign in';
var uemail ='onlinetax005@gmail.com';
var pw ='Myob1234';




describe('an angular-compatible webdriverjs client', function() {
  var webdriverjsAngular =  require('webdriverjs-angular');

  var client;

  before(function(done) {
    client = webdriverjsAngular
      .remote(require('../../../conf/webdriver-chrome.conf.js'))
      .init()
      .url(baseUrl, done);
  });




  after(function(done) {
    client.end(done);
  });

  it('waits for angularjs after clicking an element', function(done) {
    client
      .url(baseUrl)
      .getTitle(function(err, title) {
        console.log('Title was: ' + title);
        //expect(value).to.equal(title);
      })
      .setValue('#Username', uemail)
      .setValue('#Password', pw)
      .submitForm('#submit')
      .pause(3000)
      .url(urltax)
      .click('[href="#/tax/fbt"]')
      .pause(2000)
      .click('[href="#/tax/new"]')
      .getText('.ng-scope:nth-child(1)', function(err, text) {
        assert.equal(err, null);
        assert.equal(text, 'This is the partial for view 2.');
        done(err);
      });
  });



});


/*
 <h2 class="ng-binding">Tax 2015 <a href="/tax/new" ui-sref="tax.new" class="page-header-cta btn btn-success">Add New Form</a></h2>
 */
