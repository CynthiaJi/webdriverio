Feature: AndroidMobileFeature


@TC1546

Scenario Outline: TS1546Mobile
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>

 
Examples:  
    | mybrowser | GoogleHome          | myword  |
    | "android42M" | "http://www.google.com.au" | "Test IE09" |
	| "android41M" | "http://www.google.com.au" | "MYOB IE11" |
    | "android40M" | "http://www.google.com.au" | "Browser IE10" |