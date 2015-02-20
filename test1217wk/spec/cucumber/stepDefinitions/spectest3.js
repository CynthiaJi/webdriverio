/**
* Created by online on 17/12/14.
*/

var chai = require('chai');
var chaiAsPromised = require('chai-as-promised');
chai.use(chaiAsPromised);

var expect = chai.expect;

var url ='http://juliemr.github.io/protractor-demo/';
var firstNumber = element(by.model('first'));
var secondNumber = element(by.model('second'));
var goButton = element(by.id('gobutton'));
//var latestResult = element(by.binding('latest'));

module.exports = function() {

    this.Given(/^I am on the protractor page http:\/\/juliemr\.github\.io\/protractor\-demo\/$/, function (url, next) {
        // Write code here that turns the phrase above into concrete actions
        //callback.pending();
        browser.get(url);
        browser.sleep(3000);
        next();

    });

    this.Then(/^I should see a (\d+) and (\d+)$/, function (num1, num2, next) {
        // Write code here that turns the phrase above into concrete actions
        //callback.pending();
        firstNumber.sendkeys(num1);
        secondNumber.sendkeys(num2)

    });

    this.Then(/^I should see a (\d+)$/, function (num3, next) {
        // Write code here that turns the phrase above into concrete actions
        //callback.pending();
        goButton.click();

        expect(latestResult.getText()).toEqual(num3);
    });
});


