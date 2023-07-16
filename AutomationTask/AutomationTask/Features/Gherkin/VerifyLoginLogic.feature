Feature: Verify Login Logic
	Simple calculator for adding two numbers

Scenario Outline: Check accaunt login logic is work correctly with correct abd incorrect user data
	Given Authorization login page was opened
	When  The Login labels is filled by <UserData> user data
		And The 'Login to your personal account' button is clicked
	Then The 'Error message' message <ErrorStatus> displayed
		And The 'Create Account' page <PageStatus> opened
	
	Examples: 
			| UserData  | ErrorStatus | PageStatus |
			| Correct   | is not      | is         |
			| Incorrect | is          | is not     |