Feature: Verification Of The Authorization Page

Scenario: Verify the correctness of the welcome message on the authorization page
	Given Authorization login page has been opened
	Then The welcome message is written correctly depending on the current time
