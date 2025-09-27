Feature: UsingCalculatorAvailability 
	In order to calculate MTBF and Availability 
	As someone who struggles with math 
	I want to be able to use my calculator to do this 

@Availability 
Scenario: Calculating MTBF 
	Given I have a calculator 
	When I have entered 1000 and 1000 into the calculator and press MTBF 
	Then the availability result should be "2000"
	
@Availability 
Scenario: Calculating Availability 
	Given I have a calculator 
	When I have entered 1000 and 1000 into the calculator and press Availability 
	Then the availability result should be "0.5" 

@Availability 
Scenario: Calculating MTBF with negatives 
	Given I have a calculator 
	When I have entered -1 and -1 into the calculator and press MTBF 
	Then an ArgumentException should be thrown 1

@Availability 
Scenario: Calculating Availability with zeroes 
	Given I have a calculator 
	When I have entered 0 and 0 into the calculator and press Availability
	Then an ArgumentException should be thrown 1