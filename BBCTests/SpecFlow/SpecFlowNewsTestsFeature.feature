Feature: SpecFlowNewsTestsFeature
	As a user I want to read the news article

@mytag
Scenario: Read the headline title
	Given User on main page
	When I go to news page
	Then I read the head title

Scenario: Read the headline title
	Given User on main page
	When I go to news page
	Then I read the four second "<title>"
	| id | title													|
	| 1  |  "New UK virus measures 'not a second lockdown' says PM" |
	| 2  |  "Facebook 'profits from hate' claims ex-engineer"		|
	| 3  |  "New York’s last great jazz parlour"					|
	| 4  |  "The buildings warmed by the human body"				|

Scenario: Read the headline title
	Given User on main page
	When I go to search page
	And Enter the search title
	Then I read the headtitle