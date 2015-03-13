Feature: SafariFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@TC060101

Scenario Outline: TS060101Safari
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>


Examples:
    | mybrowser | GoogleHome          | myword  |
   	| "Safari51os81r01" | "http://www.google.com.au" | "Test IE09" |
	| "Safari51os80r08" | "http://www.google.com.au" | "MYOB IE11" |
    | "Safari51os70r10"  | "http://www.google.com.au" | "Browser IE10" |