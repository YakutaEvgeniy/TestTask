Feature: Verify Knowledge Base Logic


Scenario: Check if all knowledges display correctly on 'Knowledge Base' page
	Given Support page was opened
	When  The 'Go to Knowledge Base' button is clicked
	Then The 'Knowledge Base' tab is opened 
		And The Knowledges from table are presented correctly on 'Knowledge Base' page:
			| Name														   | isPresent |
			| Схемы работы												   | true      |
			| Проекты													   | true      |
			| Регистрация ККТ // Перерегистрация ККТ // Снятие с учета ККТ | true      |
			| Модели ККТ и инструкции к ним								   | true      |
			| Модули оплат для Интернет-эквайринга						   | true      |
			| LIFE PAY											           | true      |
			| LIFE POS												       | true      |
			| Интеграция со сторонними системами (CRM)					   | true      |
			| Готовые модули фискализации для CMS интернет эквайринга	   | true      |
			| Модули для популярных CMS									   | true      |
			| СБП														   | true      |
			| Оборудование												   | true      |
			| Личный кабинет интернет эквайринга				           | true      |
			| Бухгалтерские и финансовые документы						   | true      |
			| Эквайринг													   | true      |

Scenario Outline: Check if all knowledges files on 'Knowledge Base' page are equal to files in <KnowledgeName> page
	Given Support page was opened
	When  The 'Go to Knowledge Base' button is clicked
	Then The 'Knowledge Base' tab is opened 
		And The <KnowledgeName> knowledge is Displayed on 'Knowledge Base' page
	When The files count in <KnowledgeName> is remembered as 'FilesCount'
		And The file names in <KnowledgeName> are remembered as 'FilesName'
		And The <KnowledgeName> link is clicked
	Then The page for <KnowledgeName> is opened
		And Files Count in <KnowledgeName> page is equal to 'FilesCount'
		And File Names in <KnowledgeName> page are equal to 'FilesName'

	Examples: 
			| KnowledgeName												   |
			| Схемы работы												   |
			| Проекты													   |
			| Регистрация ККТ // Перерегистрация ККТ // Снятие с учета ККТ |
			| Модели ККТ и инструкции к ним								   |
			| Модули оплат для Интернет-эквайринга						   |
			| LIFE PAY											           |
			| LIFE POS												       |
			| Интеграция со сторонними системами (CRM)					   |
			| Готовые модули фискализации для CMS интернет эквайринга	   |
			| Модули для популярных CMS									   |
			| СБП														   |
			| Оборудование												   |
			| Личный кабинет интернет эквайринга				           |
			| Бухгалтерские и финансовые документы						   |
			| Эквайринг													   |
			