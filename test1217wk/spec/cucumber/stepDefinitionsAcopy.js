// Use the external Chai As Promised to deal with resolving promises in
// expectations.
var chai = require('chai');
var chaiAsPromised = require('chai-as-promised');
chai.use(chaiAsPromised);

var expect = chai.expect;

// Chai expect().to.exist syntax makes default jshint unhappy.
// jshint expr:true

module.exports = function() {

    this.Given(/^I run Cucumber with Protractor$/, function(next) {
        next();
        browser.sleep(3000);
    });

    this.Given(/^I go on(?: the website)? "([^"]*)"$/, function(url, next) {
        browser.get(url);
        browser.sleep(3000);
        next();
    });

    this.Then(/^it should still do normal tests$/, function(next) {

        expect(true).to.equal(true);
        browser.sleep(3000);
        next();
    });

    this.Then(/^it should expose the correct global variables$/, function(next) {
        browser.sleep(3000);
        expect(protractor).to.exist;
        browser.sleep(3000);
        expect(browser).to.exist;
        browser.sleep(3000);
        expect(by).to.exist;
        expect(element).to.exist;
        expect($).to.exist;
        next();
    });

    this.Then(/the title should equal "([^"]*)"$/, function(text, next) {
        expect(browser.getTitle()).to.eventually.equal(text).and.notify(next);
    });

};
