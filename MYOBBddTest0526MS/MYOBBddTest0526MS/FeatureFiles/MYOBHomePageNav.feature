Feature: MYOBHomePageNav
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: MYOBHomePageNav
Given I am on the myob home page
When I click a link with text "Support"
Then I should see the page "Support" Loaded
When I check a new page with text "Partners"
Then I should see the different page "Partners" Loaded
