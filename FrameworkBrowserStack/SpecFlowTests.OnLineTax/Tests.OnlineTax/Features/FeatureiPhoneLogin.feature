Feature: FeatureiPhoneLogin
OnLineTaxLoginMobile - iPhone
 

@TC978
Scenario Outline: TSuite978iPhone
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser               | username      | password        | mytitle                            | mytitle2          |
	| "iPadSafari_61" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPadSafari_70" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone61Safari_5" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70Safari_5C" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70Safari_5S" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
