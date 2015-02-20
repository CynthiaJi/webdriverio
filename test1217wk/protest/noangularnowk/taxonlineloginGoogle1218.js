


describe('tax online google log in', function() {


    var url1 ='https://test.secure.myob.com/';
    var url2 ='http://qa5-clientportalweb.elasticbeanstalk.com/';
    var mywait =browser.driver.sleep(3000);




    var mytitle1 = 'MYOB Account - Sign in';
    var mytitle2 = 'Practice Online';
    var titile3 ='Client Portal';
    var logemail = 'onlinetax005@gmail.com';
    var logpw='Myob1234';





    beforeEach(function() {
        browser.driver.get("http://qa5-clientportalweb.elasticbeanstalk.com/login");
        browser.driver.sleep(3000);


    /*
     <a ng-click="logout()">Log Out
     <button class="btn btn-login" ng-click="loginOauth('myob')">
     <img src="/images/myob-logo.ea0dda32.svg" alt="Logo Name" class="icon-logo"> Login with MYOB</button>
     <button class="btn btn-google-login" ng-click="loginOauth('google')"><i class="fa fa-google-plus"></i> Login with Google+</button>
     //"button.btn.btn-login"
     //loginOauth('myob')
     //Login with MYOB
     //browser.driver.findElement(By.css('Button[ng-click^= "Login with MYOB"]')).click();i
     //browser.driver.findElement(WebdriverBy.css('Button[ng-click^= "Login with MYOB"]')).click();
     // MYOB Account - Sign in
     html/body/div[2]/div/div/div/div/div/div[1]/button[1]
     browser.driver.findElement(By.css('Button[ng-click^= "Login with MYOB"]')).click();
     html/body/div[2]/div/div/div/div/div/div[1]/button[1]
      */

        browser.driver.findElement(By.xpath('html/body/div[2]/div/div/div/div/div/div[1]/button[1]')).click();




        browser.driver.sleep(3000);


    });


    it('should have a title - Client Portal', function() {

        browser.driver.navigate(url1);
        browser.driver.sleep(3000);
        expect(browser.driver.getTitle()).toEqual('Client Portal');

    });

    it('should allow cynthia login', function(){


        //
        // https://test.secure.myob.com/oauth2/Account/Login?ReturnUrl=%2foauth2%2faccount%2fauthorize%3fresponse_type%3dcode%26redirect_uri%3dhttp%253A%252F%252Fqa5-clientportalweb.elasticbeanstalk.com%252Fauth%252Fmyob%252Fcallback%26scope%3dpractice.online%2520client.portal%2520mydot.contacts.read%2520AccountantsFramework%26client_id%3dClientPortal&response_type=code&redirect_uri=http%3A%2F%2Fqa5-clientportalweb.elasticbeanstalk.com%2Fauth%2Fmyob%2Fcallback&scope=practice.online%20client.portal%20mydot.contacts.read%20AccountantsFramework&client_id=ClientPortal
        browser.driver.sleep(3000);
        browser.driver.findElement(By.id("Username")).clear();
        browser.driver.findElement(By.id("Username")).sendKeys("cynthia.ji@myob.com");
        browser.driver.findElement(By.id("Password")).clear();
        browser.driver.findElement(By.id("Password")).sendKeys("Myob1234");
        browser.driver.findElement(By.id("submit")).click();

        //expect(this.isTrue(true));

    });


    it('should have a title - Practice Online', function() {


        browser.driver.get(url2 );
        expect(browser.driver.getTitle()).toEqual(mytitle2);
        browser.driver.findElement(By.css("a.pull-left")).click();
        browser.driver.get(url2 + "/tasks");

        //String Client Portal = browser.driver.getTitle();

        browser.driver.findElement(By.css("i.fa.fa-bars")).click();
        browser.driver.findElement(By.linkText("Completed Tasks")).click();


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
        // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
        //browser.driver.findElement(By.css("button.btn.btn-google-login")).click();
        //browser.driver.findElement(By.id("choose-account-0")).click();







    });



});

/*

 public class TaxOnLineLoginQA5 {
 private WebDriver driver;
 private String baseUrl;
 private boolean acceptNextAlert = true;
 private StringBuffer verificationErrors = new StringBuffer();

 @Before
 public void setUp() throws Exception {
 driver = new FirefoxDriver();
 baseUrl = "http://qa5-clientportalweb.elasticbeanstalk.com/";
 browser.driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
 }

 @Test
 public void testTaxOnLineLoginQA5() throws Exception {

 browser.driver.get("http://qa5-clientportalweb.elasticbeanstalk.com/");
 browser.driver.findElement(By.cssSelector("button.btn.btn-login")).click();
 // https://test.secure.myob.com/oauth2/Account/Login?ReturnUrl=%2foauth2%2faccount%2fauthorize%3fresponse_type%3dcode%26redirect_uri%3dhttp%253A%252F%252Fqa5-clientportalweb.elasticbeanstalk.com%252Fauth%252Fmyob%252Fcallback%26scope%3dpractice.online%2520client.portal%2520mydot.contacts.read%2520AccountantsFramework%26client_id%3dClientPortal&response_type=code&redirect_uri=http%3A%2F%2Fqa5-clientportalweb.elasticbeanstalk.com%2Fauth%2Fmyob%2Fcallback&scope=practice.online%20client.portal%20mydot.contacts.read%20AccountantsFramework&client_id=ClientPortal
 browser.driver.findElement(By.id("Username")).clear();
 browser.driver.findElement(By.id("Username")).sendKeys("cynthia.ji@myob.com");
 browser.driver.findElement(By.id("Password")).clear();
 browser.driver.findElement(By.id("Password")).sendKeys("Myob1234");
 browser.driver.findElement(By.id("submit")).click();
 browser.driver.findElement(By.cssSelector("a.pull-left")).click();
 browser.driver.get(baseUrl + "/tasks");
 String Client Portal = browser.driver.getTitle();
 browser.driver.findElement(By.cssSelector("i.fa.fa-bars")).click();
 browser.driver.findElement(By.linkText("Completed Tasks")).click();
 for (int second = 0;; second++) {
 if (second >= 60) fail("timeout");
 try { if ("Client Portal".equals(browser.driver.getTitle())) break; } catch (Exception e) {}
 Thread.sleep(1000);
 }

 browser.driver.findElement(By.linkText("Documents")).click();
 browser.driver.findElement(By.linkText("Task Centre")).click();
 browser.driver.findElement(By.linkText("Completed Tasks")).click();
 browser.driver.findElement(By.linkText("Documents")).click();
 browser.driver.findElement(By.linkText("Correspondence")).click();
 browser.driver.findElement(By.linkText("Financial Planning")).click();
 browser.driver.findElement(By.linkText("General")).click();
 browser.driver.findElement(By.linkText("Tax and Accounting")).click();
 browser.driver.findElement(By.cssSelector("span.user-name.ng-binding")).click();
 browser.driver.findElement(By.linkText("Log Out")).click();
 // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | null | ]]
 browser.driver.findElement(By.cssSelector("button.btn.btn-google-login")).click();
 browser.driver.findElement(By.id("choose-account-0")).click();
 }

 @After
 public void tearDown() throws Exception {
 browser.driver.quit();
 String verificationErrorString = verificationErrors.toString();
 if (!"".equals(verificationErrorString)) {
 fail(verificationErrorString);
 }
 }

 private boolean isElementPresent(By by) {
 try {
 browser.driver.findElement(by);
 return true;
 } catch (NoSuchElementException e) {
 return false;
 }
 }

 private boolean isAlertPresent() {
 try {
 browser.driver.switchTo().alert();
 return true;
 } catch (NoAlertPresentException e) {
 return false;
 }
 }

 private String closeAlertAndGetItsText() {
 try {
 Alert alert = browser.driver.switchTo().alert();
 String alertText = alert.getText();
 if (acceptNextAlert) {
 alert.accept();
 } else {
 alert.dismiss();
 }
 return alertText;
 } finally {
 acceptNextAlert = true;
 }
 }
 }

 */