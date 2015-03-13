Feature: FeatureOpera

OnLineTaxLoginDeskTop
OLTLoginDTop

@TC613
Scenario Outline: TSuite38Opera
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser               | username      | password        | mytitle                            | mytitle2          |
    | "Opera1215os70r11" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "Opera1216os80r08"  | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "Opera1216os81r01" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |