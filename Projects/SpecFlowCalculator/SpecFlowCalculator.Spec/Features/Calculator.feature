Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**
# My Personal Scenario: 
@Addition
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: 2nd Add two numbers
	Given the first number is 20
	And the second number is 30
	When the two numbers are added
	Then the result should be 50

@Subtraction
Scenario: Subtract two Numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are subtracted
	Then the result should be -20

Scenario: 2nd Subtract two Numbers
	Given the first number is 100
	And the second number is 50
	When the two numbers are subtracted
	Then the result should be 50

@Mulitplication
Scenario: 2nd Multiply two Numbers
	Given the first number is 200
	And the second number is 10
	When the two numbers are multiplied
	Then the result should be 2000

Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 50

@Division
Scenario: Divide two numbers
	Given the first number is 20
	And the second number is 10
	When the two numbers are divided
	Then the result should be 2

Scenario: 2nd Divide two numbers
	Given the first number is 0
	And the second number is 1
	When the two numbers are divided
	Then the result should be 0

Scenario: Divide by 0
	Given the first number is 1
	And the second number is 0
	When the two numbers are divided
	Then the user is presented with an error message

Scenario: Divide by two number
	Given the first number is 3
	And the second number is 2
	When the two numbers are divided
	Then the result should be 1.5

# Specflow 9 Tests Scenarios

Scenario: Heber Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Heber Add two other numbers
	Given the first number is 50
	And the second number is 60
	When the two numbers are added
	Then the result should be 110

Scenario: Heber Subtract a small number from a bigger number
	Given the first number is 100
	And the second number is 75
	When the two numbers are subtracted
	Then the result should be 25

Scenario: Heber Subtract a bigger number from a smaller number
	Given the first number is 10
	And the second number is 75
	When the two numbers are subtracted
	Then the result should be -65

Scenario: Heber Multiply two positive numbers
	Given the first number is 100
	And the second number is 75
	When the two numbers are multiplied
	Then the result should be 7500

 
Scenario: Heber assignment 1
	Given the first number is 100
	When operation + is done to the number 50
	And operation + is done to the number 80
	Then the result should be 230

	
Scenario: Heber assignment 2
	Given the first number is 100
	When operation + is done to the number 50
	And operation + is done to the number 80
	And operation + is done to the number 80
	Then the result should be 310

Scenario: Heber assingment 3
	Given the first number is 100
	When operation + is done to the number 50
	And operation + is done to the number 80
	And operation + is done to the number 80
	And operation / is done to the number 10
	Then the result should be 31

 
Scenario: Heber assignment 4
	Given the first number is 100
	When operation / is done to the number 50
	And operation - is done to the number 2
	And operation + is done to the number 10
	And operation % is done to the number 3
	Then the result should be 1