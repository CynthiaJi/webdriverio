Feature: FeatureGoogleChrome
OnLineTaxLoginDeskTop
OLTLoginDTop

@TC590
Scenario Outline: TSuite41GC
	Given 	BrowserName <mybrowser>
	And Navigate to the OnLineTax  Homepage with title <mytitle>
	When Login with <username>  Password  <password>  page tile  <mytitle2>
	Then Logout   <mytitle>

	Examples:
    | mybrowser      | username      | password    | mytitle                  | mytitle2          |
    | "GC340os70r11" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "GC350os80r08" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |
    | "GC360os81r01" | "ivan@my.com" | "password1" | "MYOB Account - Sign in" | "MYOB Account - Authorisation" |