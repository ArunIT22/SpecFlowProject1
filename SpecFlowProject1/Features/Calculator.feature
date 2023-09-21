Feature: Calculator
As I developer I wrote Calculator 
Which I want to test

@tag1
Scenario: Add Number
	Given First number is 50
	And then second number is 40
	When the two numbers are added
	Then  the result should be 90

Scenario: Subtract Number
	Given I have give the values below
	#DataTable
	| num1 | num2 |
	| 50   | 40   |
	When I call the SubstractNumber method
	Then It should result 10

Scenario Outline: Divide Number
	Given I have give <num1> and <num2>
	When I call the Divide method
	Then the result is <result>

Examples: 
	| num1 | num2 | result |
	| 0    | 5    | 0      |
	| 5    | 0    | 0      |
	| 6    | 2    | 3      |
