/**
 * Created by online on 6/03/15.
 */


    /**
var webdriver = require('selenium-webdriver');

var driver = new webdriver.Builder().
    withCapabilities(webdriver.Capabilities.chrome()).
    build();
*/
    var  baseUrl = "http://www.pactera.com/";
    var curTitle ='Global IT Consulting, Solution, and Outsourcing Services from Pactera';
        var mySearch ="test automation";

describe('Search test', function () {
    browser.ignoreSynchromization = true;
    browser.driver.manage().window().maximize();
    it('should be on correct page', function () {

        browser.driver.get(baseUrl);
        browser.driver.getTitle().then(function(title) {
            expect(title).toEqual(curTitle);
            console.log(title);
        });
    });
    it('search for test automation', function () {
        browser.driver.get(baseUrl);

        browser.driver.findElement(by.id('s')).clear();
        browser.driver.findElement(by.id('s')).sendKeys('test automation');
        browser.driver.findElement(by.id('searchsubmit')).click();
        browser.driver.getTitle().then(function(title) {
            expect(title).toEqual('test automation | Search Results | Pactera');
            console.log(title);
        });
    });
});


/*
*
*
* angularjs without
* browser.ignoreSynchronization = true
* browser.driver.manage().window().maximize();
 http://stackoverflow.com/questions/20927652/how-to-use-protractor-on-non-angularjs-website
 browser.driver.findElement(by.id('username')).sendKeys('Jane');
 browser.driver.findElement(by.id('password')).sendKeys('1234');
 browser.driver.findElement(by.id('clickme')).click();
angular with
 browser.element(by.id('s')).sendKeys('test automation');
 browser.element(by.id('searchsubmit')).click();
 browser.getTitle().then(function(title) {
 expect(title).toEqual('test automation | Search Results | Pactera');
 console.log(title);

 });
 */
