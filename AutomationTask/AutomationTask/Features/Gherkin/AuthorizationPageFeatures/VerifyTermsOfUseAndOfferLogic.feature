Feature: Verify Terms Of Use And Offer Logic

Scenario Outline: Verify if Terms Of Use And Offer Logic links work correctly
	Given Authorization login page was opened
	Then The 'Create an account' link is presented on 'Authorization' page
	When The 'Create an account' link is clicked
	Then The 'Create Account' page is opened
		And  The '<LinkName>' link is presented on 'Create Account' page
	When The '<LinkName>' link is clicked
	Then The '<LinkName>' tab is Displayed
	When The tab '<LinkName>' is closed
	Then The 'Create Account' tab is Displayed

	Examples: 
			| LinkName	   |
			| Terms Of Use |
			| Offer		   | 