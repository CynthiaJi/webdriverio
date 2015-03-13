Feature: MobileiPhoneAndroidFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@TC462

Scenario Outline: TS462Mobile
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>


Examples:
    | mybrowser | GoogleHome          | myword  |
    | "iPhone70Safari_5C" | "http://www.google.com.au" | "MYOB IE11" |
    | "iPhone70Safari_5S"  | "http://www.google.com.au" | "Browser IE10" |
	| "iPhone61Safari_5" | "http://www.google.com.au" | "Test IE10" |
	| "android42M" | "http://www.google.com.au" | "Test IE09" |
	| "android41M" | "http://www.google.com.au" | "MYOB IE11" |
    | "android40M" | "http://www.google.com.au" | "Browser IE10" |