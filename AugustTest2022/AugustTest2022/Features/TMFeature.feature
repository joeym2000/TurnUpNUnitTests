Feature: TMFeature

A short summary of the feature

@tag1
Scenario: Create time and material record with valid details
	Given the user log in to turn up potal succcessfully
	And user navigate to time and material page
	When  user create a new time and mterial record
	Then the record should be created successfully
