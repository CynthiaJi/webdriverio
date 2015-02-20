//title
//Client Portal


describe('tax online google log in', function() {


    var url1 ='https://test.secure.myob.com/';
    var url2 ='http://qa5-clientportalweb.elasticbeanstalk.com/';




    var mytitle1 = 'MYOB Account - Sign in';
    var mytitle2 = 'Practice Online';
    var logemail = 'onlinetax005@gmail.com';
    var logpw='Myob1234';





    beforeEach(function() {
        //browser.driver.get(url1+'/oauth2/Account/Login?ReturnUrl=%2f');
        browser.driver.get(url2);
        browser.driver.sleep(30000);

    });




    it('should allow cynthia login', function(){

        browser.driver.findElement(By.className()("button.btn.btn-login")).click();
        browser.driver.sleep(30000);

        browser.driver.findElement(By.id("Username")).clear();
        browser.driver.findElement(By.id("Username")).sendKeys("cynthia.ji@myob.com");
        browser.driver.findElement(By.id("Password")).clear();
        browser.driver.findElement(By.id("Password")).sendKeys("Myob1234");


    });


    it('should have a title - MYOB Account - Sign in', function() {
        expect(browser.driver.getTitle()).toEqual(mytitle1);

        browser.driver.findElement(By.id("submit")).click();



    });


    it('should have a title -  Practice Online', function() {

            browser.driver.sleep(30000);






         expect(browser.getTitle()).toEqual(mytitle2);
        browser.driver.findElement(By.css("a.pull-left")).click();
        browser.driver.findElement(By.linkText("Documents")).click();
        browser.driver.findElement(By.linkText("Task Centre")).click();
        browser.driver.findElement(By.linkText("Completed Tasks")).click();
        browser.driver.findElement(By.linkText("Documents")).click();
        browser.driver.findElement(By.linkText("Correspondence")).click();
        browser.driver.findElement(By.linkText("Financial Planning")).click();
        browser.driver.findElement(By.linkText("General")).click();
        browser.driver.findElement(By.linkText("Tax and Accounting")).click();
        browser.driver.findElement(By.css("span.user-name.ng-binding")).click();
        browser.driver.findElement(By.linkText("Log Out")).click();





    });
});

/*
 baseUrl = "http://qa5-clientportalweb.elasticbeanstalk.com/";
 driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
 }

 @Test
 public void testTaxOnLineLoginQA5javaWebdriver() throws Exception {
 driver.get(baseUrl + "/");
 driver.findElement(By.id("errorTryAgain")).click();
 driver.findElement(By.cssSelector("button.btn.btn-login")).click();
 // ERROR: Caught exception [Error: locator strategy either id or name must be specified explicitly.]
 driver.findElement(By.id("Username")).clear();
 driver.findElement(By.id("Username")).sendKeys("cynthia.ji@myob.com");
 driver.findElement(By.id("Password")).clear();
 driver.findElement(By.id("Password")).sendKeys("Myob1234");
 driver.findElement(By.id("submit")).click();
 driver.findElement(By.cssSelector("a.pull-left")).click();
 driver.findElement(By.linkText("Documents")).click();
 driver.findElement(By.linkText("Task Centre")).click();
 driver.findElement(By.linkText("Completed Tasks")).click();
 driver.findElement(By.linkText("Documents")).click();
 driver.findElement(By.linkText("Correspondence")).click();
 driver.findElement(By.linkText("Financial Planning")).click();
 driver.findElement(By.linkText("General")).click();
 driver.findElement(By.linkText("Tax and Accounting")).click();
 driver.findElement(By.cssSelector("span.user-name.ng-binding")).click();
 driver.findElement(By.linkText("Log Out")).click();
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