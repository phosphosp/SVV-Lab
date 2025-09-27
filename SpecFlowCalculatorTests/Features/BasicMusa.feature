Feature: UsingCalculatorBasicReliability 
	In order to calculate the Basic Musa model's failures/intensities 
	As a Software Quality Metric enthusiast 
	I want to use my calculator to do this

@BasicMusa
Scenario: Calculating current failure intensity
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press fail 
	Then the basic musa result should be <value4>
	Examples:  
	| value1 | value2 | value3 | value4 |
	|10|50|100|5|
	|20|25|200|17.5|
	|15|30|150|12|
	
@BasicMusa 
Scenario: Calculating average number of expected failures 
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press expfail 
	Then the basic musa result should be <value4>
	Examples:
	| value1 | value2 | value3 | value4 |
	|10|5|100|39|
    |20|3|200|52|
    |15|10|150|95|

@BasicMusa 
Scenario: Calculating current failure intensity with zeroes, negatives, or exceeded average number of failures 
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press fail 
	Then an ArgumentException should be thrown 2
	Examples: 
	|value1 |value2 |value3 |
	|0|0|0|
	|-1|-1|-1| 
	|1|110|100| 

@BasicMusa 
Scenario: Calculating average number of expected failures with zeroes or negatives 
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press expfail
	Then an ArgumentException should be thrown 2
	Examples: 
	|value1 |value2 |value3 |
	|0|0|0|
	|-1|-1|-1| 
