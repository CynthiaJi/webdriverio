// Use the external Chai As Promised to deal with resolving promises in
// expectations.
var chai = require('chai');
var chaiAsPromised = require('chai-as-promised');
chai.use(chaiAsPromised);

var expect = chai.expect;

// Chai's expect().to.exist style makes default jshint unhappy.
// jshint expr:true

var url1 = 'https://test.secure.myob.com/';

var url2 = 'http://qa5-clientportalweb.elasticbeanstalk.com/';

var url3 = 'http://qa5.addevcloudsites.myob.com/clients';
var redi = 'ReturnUrl=%2foauth2%2faccount%2fauthorize%3fresponse_type%3dcode%26redirect_uri%3dhttp%253A%252F%252Fqa5-clientportalweb.elasticbeanstalk.com%252Fauth%252Fmyob%252Fcallback%26scope%3dpractice.online%2520client.portal%2520mydot.contacts.read%2520AccountantsFramework%26client_id%3dClientPortal&response_type=code&redirect_uri=http%3A%2F%2Fqa5-clientportalweb.elasticbeanstalk.com%2Fauth%2Fmyob%2Fcallback&scope=practice.online%20client.portal%20mydot.contacts.read%20AccountantsFramework&client_id=ClientPortal';

//http://qa5-clientportalweb.elasticbeanstalk.com/tasks
var titile1 ='MYOB Account - Sign in';
var title2 = 'Practice Online';


describe('Tax', function() {


  it('MYOB login', function(){
  browser.driver.manage().window().maximize();
  browser.driver.get(url2);
  browser.driver.findElement(By.id('Username')).clear();
  browser.driver.findElement(By.id('Username')).sendKeys('onlinetax005@gmail.com');
  browser.driver.findElement(By.id('Password')).clear();
  browser.driver.findElement(By.id('Password')).sendKeys('Myob1234');
  //String MYOB Account - Sign in = browser.driver.getTitle();
  browser.driver.sleep(3000);
  expect(browser.driver.getTitle()).toEqual(titile1);
});



  it('should expose the correct global variables', function() {
    browser.driver.findElement(By.id('submit')).click();
    expect(browser.driver.getTitle()).toEqual(title2);
  });

  it('3 Document', function () {
    browser.By.linkText('Documents');
    expect(browser.driver.getTitle()).toMatch("Documents");
  });
});
