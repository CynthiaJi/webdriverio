Feature: IEFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@TC0901IE

Scenario Outline: TS901IE
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>
 
 
Examples: 
    | mybrowser | GoogleHome          | myword  |
    | "IE11os70r08" | "http://www.google.com.au" | "MYOB IE11" |
    | "IE10os80r10"  | "http://www.google.com.au" | "Browser IE10" |
	| "IE10os70r10" | "http://www.google.com.au" | "Test IE10" |
	| "IE09os70r11" | "http://www.google.com.au" | "Test IE09" |
	| "IE11os81r01" | "http://www.google.com.au" | "Test 11" |
	| "IE10os80r08" | "http://www.google.com.au" | "Test 10" |