Feature: FireFoxBrowserFeature
 
@TC0601

Scenario Outline: TS0601FF
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>
 
Examples:
    | mybrowser | GoogleHome          | myword  |
    | "FF310os81r01" | "http://www.google.com.au" | "Firefox 31" |
	| "FF300os80r08" | "http://www.google.com.au" | "Firefox 30" |
	| "FF290os70r11" | "http://www.google.com.au" | "Firefox 29" |
	| "FF310os80r08" | "http://www.google.com.au" | "Firefox 28" |