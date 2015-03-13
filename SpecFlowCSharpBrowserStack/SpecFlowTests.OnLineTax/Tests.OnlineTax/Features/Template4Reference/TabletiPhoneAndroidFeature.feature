Feature: TabletiPhoneAndroidFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@TC010702

Scenario Outline:TSmobileGoogleSearch010702
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>


Examples:
    | mybrowser | GoogleHome          | myword  |
    | "iPad_70" | "http://www.google.com.au" | "Test IE09" |
	| "iPad_61" | "http://www.google.com.au" | "MYOB IE11" |
	| "android41Tablet" | "http://www.google.com.au" | "MYOB IE11" |
    | "android40Tablet" | "http://www.google.com.au" | "Browser IE10" |