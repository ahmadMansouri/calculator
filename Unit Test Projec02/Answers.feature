﻿Feature: Answers

@mytag
Scenario: Example Scenario
	Given I am on the home page
	When I enter 'some text' into the 'title' input field  
		And I click the 'submit' control
	Then 'some text' should be displayed in the 'results' field
