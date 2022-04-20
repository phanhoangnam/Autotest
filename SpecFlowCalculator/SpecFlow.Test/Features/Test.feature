Feature: Test
	Simple test


Scenario: Login to Guru with valid account
	Given I enter valid username
	And I enter valid password
	When I click login button
	Then I see home page
	And The result should "PASSED"

Scenario Outline: Login to Guru with invalid account
	Given I enter username <username>
	And I enter password <password>
	When I click login button
	Then I see error message <error>

Examples: 
	| username   | password | error                         |
	|            |          | Password must not be blank    |
	|            | EhytahU  | User or Password is not valid |
	|            | EhytahUx | User or Password is not valid |
	| mngr392292 |          | Password must not be blank    |
	| mngr392292 | EhytahUx | User or Password is not valid |
	| mngr       |          | Password must not be blank    |
	| mngr       | EhytahU  | User or Password is not valid |
	| mngr       | EhytahUx | User or Password is not valid |