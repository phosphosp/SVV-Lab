Feature: UsingCalculatorDefectDensity 
	In order to calculate the Defect Density and current SSI
	As a Software Quality Metric enthusiast 
	I want to use my calculator to do this

@DefectDensity
Scenario: Calculating Defect Density
	Given I have a calculator 
	When I have entered <value1> and <value2> into the calculator and press dd 
	Then the defect density result should be <value3>
	Examples:  
	| value1 | value2 | value3 |
	|150|50|3|
	|100|25|4|
	|1000|100|10|
	
@SSI 
Scenario: Calculating current SSI
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press ssi 
	Then the SSI result should be <value4>
	Examples:
	| value1 | value2 | value3 | value4 |
	|10|10|5|15|
    |20|5|2|23|
    |15|10|7|18|

@DefectDensity 
Scenario: Calculating defect density with zeroes, negatives
	Given I have a calculator 
	When I have entered <value1> and <value2> into the calculator and press dd 
	Then an ArgumentException should be thrown 4
	Examples: 
	|value1 |value2 |value3 |
	|0|0|0|
	|-1|-1|-1| 

@SSI 
Scenario: Calculating SSI with negatives
	Given I have a calculator 
	When I have entered <value1> and <value2> and <value3> into the calculator and press ssi
	Then an ArgumentException should be thrown 4
	Examples: 
	|value1 |value2 |value3 |
	|-1|-1|-1| 