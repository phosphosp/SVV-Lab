Feature: UsingCalculatorLogReliability 
	In order to calculate the Logarithm Musa model's failures/intensities 
	As a Software Quality Metric enthusiast 
	I want to use my calculator to do this

@LogMusa
Scenario: Calculating log current failure intensity
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press logfail 
	Then the log musa result should be <value4>
	Examples:  
	| value1 | value2 | value3 | value4 |
	|10|50|0.02|3.68|
	
@LogMusa 
Scenario: Calculating log average number of expected failures 
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press logexpfail 
	Then the log musa result should be <value4>
	Examples:
	| value1 | value2 | value3 | value4 |
	|10|10|0.02|55|

@LogMusa 
Scenario: Calculating log current failure intensity with zeroes, negatives, or exceeded average number of failure decay
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press logfail 
	Then an ArgumentException should be thrown 3
	Examples: 
	|value1 |value2 |value3 |
	|0|0|0|
	|-1|-1|-1| 
	|1|1|1| 

@LogMusa 
Scenario: Calculating log average number of expected failures with zeroes, negatives, or exceeded average number of failure decay 
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press logexpfail
	Then an ArgumentException should be thrown 3
	Examples: 
	|value1 |value2 |value3 |
	|0|0|0|
	|-1|-1|-1| 
	|1|1|1| 

