Feature: FeatureAndroidLogin

@TC15462

Scenario Outline: TS15462Android
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

 
Examples:  
    | mybrowser    | username      | password        | mytitle                            | mytitle2          |
    | "android40M" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android40Tablet" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android41M" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android41Tablet" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android42M" |"ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |