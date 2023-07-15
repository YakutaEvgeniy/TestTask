Feature: Verification Of The Authorization Page

@mytag
Scenario: Сhecking the correctness of the welcome inscription on the authorization page
	Given Authorization login page has been opened
	Then The welcome inscription is written correctly depending on the current time
