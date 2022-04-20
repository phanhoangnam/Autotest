Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

@mytag
@DataSource:data.csv
Scenario: Add two numbers permutations
	Given the first number is <FirstNumber>
	And the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <ExpectedResult>

#Examples: 
#	| First number | Second number | Expected result |
#	| 0            | 0             | 0               |
#	| -1           | 10            | 9               |
#	| 6            | 9             | 15              |

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

#@mytag
Scenario: Work with table
	Given I input fllowing numbers to the calculator
	| Number1 | Number2 | Number3 | Number4 |
	| 2       | 3       | 5       | 8       |
	| 7       | 11      | 13      | 17      |
	| 3       | 1       | 4       | 5       |
#
#	When the two numbers are added
#	Then the result should be 5