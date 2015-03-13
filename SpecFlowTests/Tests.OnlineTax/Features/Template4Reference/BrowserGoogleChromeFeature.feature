Feature: GoogleBrowserFeature

@TC0701

Scenario Outline: TS0701GC
	Given 	BrowserName <mybrowser>
	When Navigate to Google Homepage <GoogleHome>
	And search the word <myword>
	Then Assert that page tile include <myword>

Examples:
	| mybrowser | GoogleHome          | myword  |
	| "GC360os81r01" | "http://www.google.com.au" | "Chrome 36.0" |
	| "GC350os80r08" | "http://www.google.com.au" | "Chrome 35.0" |
	| "GC340os70r11" | "http://www.google.com.au" | "Chrome 34.0" |