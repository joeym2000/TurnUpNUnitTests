Feature: TMFeature

A short summary of the feature

@tag1
Scenario: Create time and material record with valid details
	Given the user log in to turn up potal succcessfully
	When user navigate to time and material page
	And  user create a new time and material record
	Then the record should be created successfully

Scenario Outline: Edit time aand material with valid details
	Given the user log in to turn up potal succcessfully
	When user navigate to time and material page
	And user update '<Description>' existing record
	Then the record should have the updated '<Description>'

	Examples: 
	| Description |
	| Time        |
	| Material    |
	| Updated     |