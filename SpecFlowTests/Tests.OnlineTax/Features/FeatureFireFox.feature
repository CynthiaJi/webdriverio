Feature: FeatureFireFox
OnLineTaxLoginDeskTop
OLTLoginDTop

@TC623
Scenario Outline: TS38FF
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser        | username       | password         | mytitle                               | mytitle2                               |
	| "FF290os70r11" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "FF300os80r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "FF310os80r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "FF310os81r01" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |