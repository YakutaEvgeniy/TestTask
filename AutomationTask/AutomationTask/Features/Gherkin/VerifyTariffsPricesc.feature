Feature: Verify Tariff prices
	Simple calculator for adding two numbers

Scenario: Verify if tariff prices displays correctly
	Given Support page was opened
	When  The 'Tariffs' button is clicked
	Then The 'Tariffs' page is opened 
		And The Tariffs  prices is Displayed correctly:
			| Tarrif_Nane | Price |
			| Лайт        | 0     |
			| Базовый     | 0     |
			| Стартовый   | 300   |
			| Продвинутый | 700   |