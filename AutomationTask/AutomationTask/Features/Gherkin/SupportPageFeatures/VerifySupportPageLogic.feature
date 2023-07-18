Feature: Verify Support Page Logic

Scenario: Check if support page opens correctly from register page
	Given Authorization login page was opened
	Then The 'Create an account' link is presented on 'Authorization' page
	When The 'Create an account' link is clicked
	Then The 'Create Account' page is opened
		And  The 'Support' link is presented on 'Create Account' page
	When The 'Support' link is clicked
	Then The 'Support' page is opened
		And The 'Cashback' popup is Displayed
	When The 'Cashback' popup is closed
	Then The communication methods from table is present on 'Support' page:
		| Methods  |
		| Telegram |
		| WhatsUp  |
		| Phone    |
		And The 'Support' page is contained menu items from the table:
			| Items			     |
			| Платежные продукты |
			| Кассовые продукты  |
			| Оборудование       |
			| Тарифы			 |
			| Поддержка          |
			| Ещё		         |
		And And The 'Go to Knowledge Base' button is Displayed
		And And The 'Write To Us' button is Displayed
