Feature: Verify Create Account Logic

Scenario: Check that create a personal account button is disable without SMS code
	Given Authorization login page was opened
	Then The 'Create an account' link is presented on 'Authorization' page
	When The 'Create an account' link is clicked
	Then The 'Create Account' page is opened
		And The 'create a personal account' button is Disabled
	When The Create Account labels is filled by data from table:
		 | Phone_Number | Name       | Password |
		 | 1234567890   | Jhon Smith | 12345    |
	Then The 'SMS code' label is Disabled
		And The 'create a personal account' button is Disabled
