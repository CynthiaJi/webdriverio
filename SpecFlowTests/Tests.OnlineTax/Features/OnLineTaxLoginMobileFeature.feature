Feature: OnLineTaxLoginMobileFeature
Practice Online
MYOB Account - Authorisation
OnLineTaxLoginMobileTablet
OLTLoginMT

@TC6146
Scenario Outline: TSuite6146
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser      | username      | password    | mytitle                  | mytitle2          |
	| "android40M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android40M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android40Tablet" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android41M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android41M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android41Tablet" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android42M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "android42M" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPad_61" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPad_70" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone61_5" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone61_5" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70_5C" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70_5C" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70_5S" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "iPhone70_5S" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
