Feature: FeatureSafariLogin
OnLineTaxLoginDeskTop
OLTLoginDTop

@TC588
Scenario Outline: TSuite43Safari
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser      | username      | password    | mytitle                  | mytitle2          |
    | "Safari51os70r10" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "Safari51os80r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "Safari51os81r01" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |