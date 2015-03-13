Feature: iPhoneFeature

@TC090401

Scenario Outline: TS090401iPhone
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>


Examples:
    | mybrowser | GoogleHome          | myword  |
    | "iPhone70_5C" | "http://www.google.com.au" | "MYOB IE11" |
    | "iPhone70_5S"  | "http://www.google.com.au" | "Browser IE10" |
	| "iPhone61_5" | "http://www.google.com.au" | "Test IE10" |