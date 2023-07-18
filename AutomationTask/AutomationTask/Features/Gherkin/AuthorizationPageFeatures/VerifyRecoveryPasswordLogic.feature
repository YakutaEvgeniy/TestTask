Feature: Verify Recovery Password Logic

Scenario: Check if the password recovery logic works correctly
	Given Authorization login page was opened
	Then The 'Recovery password' link is presented on 'Authorization' page
	When The 'Recovery password' link is clicked
	Then The 'Recovery password login' page is opened 
	When The 'Phone Number' label is filled by '1234567890' data
		And The SMS code is received and entered
		And The 'Send SMS' button is clicked
	Then The 'Success SMS' message is Displayed
	When The 'Next' button is clicked
	Then The 'Recovery password' page is opened 
	When Password is upated by new random password and remembered as 'New_Password'
	Then The Authorization login page is opened
	When The Login labels is filled by '1234567890' number and remembered password 'New_Password'


