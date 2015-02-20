Feature: Homepage
  As a user
  I want to visit the homepage
  So that I can access the various features on offer

  Scenario: Visit Homepage
    Given I am on the protractor page http://juliemr.github.io/protractor-demo/
    Then I should see a 1 and 3
    And I should see a 4