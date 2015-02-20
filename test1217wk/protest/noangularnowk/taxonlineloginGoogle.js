//title
//Client Portal

describe('tax online google log in', function() {

    //var expect = chai.expect;


    var url1 ='https://test.secure.myob.com/';
    var url2 ='http://qa5-practiceonlineweb.elasticbeanstalk.com';
    var url3='http://qa5.addevcloudsites.myob.com/clients';


    var lName = browser.element(by.id('Username'));
    var lpw = browser.element(by.id('Password'));
    var submitBtn = browser.element(by.id('submit'));

    var mytitle1 = 'MYOB Account - Sign in';
    var mytitle2 = 'Practice Online';
    var logemail = 'onlinetax005@gmail.com';
    var logpw='Myob1234';



    function loginas(name, pw) {
        lName.clear();
        lName.sendKeys(name);
        browser.sleep(30000);
        lpw.clear();
        lpw.sendKeys(pw);
        browser.sleep(30000);
        //submitBtn.click();
    }


    beforeEach(function() {
        browser.get(url1+'/oauth2/Account/Login?ReturnUrl=%2f');

    });


    /*

    it('should allow cynthia login', function(){

        loginBtn.click();
        loginas('cynthia.ji@myob.com','Myob1234');
        submitBtn.click();

    });
*/

    it('should have a title - MYOB Account - Sign in', function() {
        expect(browser.getTitle()).toEqual(mytitle);

    });


    it('should have a title -  Practice Online', function() {

            browser.sleep(30000);
            loginas(logemail,logpw);


            submitBtn.click();
            browser.sleep(30000);
            browser.navigate().to(url3);




         expect(browser.getTitle()).toEqual(mytitle2);
        browser.sleep(30000);
        browser.navigate().to(url2);




    });
});

/*
 ^[[Aonline@OnlineTax-L1:~/test-pro-cu/test1217$ protractor protest/confcj.js
 Using the selenium server at http://localhost:4444/wd/hub
 [launcher] Running 1 instances of WebDriver
 FF

 Failures:

 1) tax online google log in should have a title - MYOB Account - Sign in
 Message:
 Error: Angular could not be found on the page https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f : retries looking for angular exceeded
 Stacktrace:
 Error: Angular could not be found on the page https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f : retries looking for angular exceeded
 ==== async task ====
 Protractor.get(https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f) - test for angular
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:37:17)
 ==== async task ====
 Asynchronous test function: beforeEach()
 Error
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:36:5)
 at Object.<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:4:1)

 2) tax online google log in should have a title - MYOB Account - Sign in
 Message:
 ReferenceError: mytitle is not defined
 Stacktrace:
 ReferenceError: mytitle is not defined
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:54:44)
 ==== async task ====
 Asynchronous test function: it()
 Error
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:53:5)
 at Object.<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:4:1)

 3) tax online google log in should have a title -  Practice Online
 Message:
 Error: Angular could not be found on the page https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f : retries looking for angular exceeded
 Stacktrace:
 Error: Angular could not be found on the page https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f : retries looking for angular exceeded
 ==== async task ====
 Protractor.get(https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f) - test for angular
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:37:17)
 ==== async task ====
 Asynchronous test function: beforeEach()
 Error
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:36:5)
 at Object.<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:4:1)

 4) tax online google log in should have a title -  Practice Online
 Message:
 Error: Error while waiting for Protractor to sync with the page: {"message":"angular is not defined","stackTrace":[{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f line 68 > Function:4","methodName":"anonymous/<","lineNumber":1},{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f line 68 > Function:1","methodName":"anonymous","lineNumber":15},{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f:68","methodName":"handleEvaluateEvent","lineNumber":20}]}
 Stacktrace:
 Error: Error while waiting for Protractor to sync with the page: {"message":"angular is not defined","stackTrace":[{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f line 68 > Function:4","methodName":"anonymous/<","lineNumber":1},{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f line 68 > Function:1","methodName":"anonymous","lineNumber":15},{"fileName":"https://test.secure.myob.com//oauth2/Account/Login?ReturnUrl=%2f:68","methodName":"handleEvaluateEvent","lineNumber":20}]}
 at Error (<anonymous>)
 ==== async task ====
 Protractor.waitForAngular()
 at loginas (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:26:15)
 ==== async task ====
 Asynchronous test function: it()
 Error
 at [object Object].<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:59:5)
 at Object.<anonymous> (/home/online/test-pro-cu/test1217/protest/taxonlineloginGoogle2.js:4:1)

 Finished in 54.775 seconds
 2 tests, 4 assertions, 4 failures

 [launcher] 0 instance(s) of WebDriver still running
 [launcher] firefox #1 failed 4 test(s)
 [launcher] overall: 4 failed spec(s)
 [launcher] Process exited with error code 1
 online@OnlineTax-L1:~/test-pro-cu/test1217$


 */