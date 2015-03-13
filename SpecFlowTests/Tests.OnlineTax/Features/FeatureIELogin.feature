Feature: FeatureIELogin
OnLineTaxLoginDeskTop
OLTLoginDTop

@TC628
Scenario Outline: TS68IE
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser | username | password | mytitle | mytitle2 |
	|"IE09os70r11" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "IE10os70r10" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
	| "IE11os70r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "IE10os80r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "IE10os80r10" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "IE11os81r01" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |