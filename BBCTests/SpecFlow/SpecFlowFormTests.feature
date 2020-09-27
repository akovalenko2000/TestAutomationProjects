Feature: SpecFlowFormTests
	As a user I want to share a story


@mytag
Scenario: User writes story without text
	Given User is on the main page
	And User goes to covid page
	And User clicks have your say
	When User enters the data
	And User clicks submit
	Then Error message is shown
| id | text				 | name | age | accept |
|  1 |    "bla-bla-bla"  |"Name"|  1  | true   |

Scenario: User writes story without name
	Given User is on the main page
	And User goes to covid page
	And User clicks have your say
	When User enters the data
	| id | text | name | age | accept |
	|  1 |   "" |  ""  |  16 | false  |
	And User clicks submit
	Then Error message is shown

Scenario: User writes story without checkbox
	Given User is on the main page
	And User goes to covid page
	And User clicks have your say
	When User enters the data
	| id | text				 | name | age | accept |
	| 1  |  "bla-bla-bla"    | ""   |  20 | true   |
	And User clicks submit
	Then Error message is shown