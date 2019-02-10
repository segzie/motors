Feature: CustomerCanViewMotorsPrice
	In order to know the cost of a car 
	As a customer 
	I want the ability to view a car price

Scenario: Customer can view the cost of a car 
	Given I navigate to Motors homepage
	When I enter postcode 
	And I select my car make  
	And I select my car model  
	And i click on search button 
	And  I click on the first car from thwe result
	Then the price of the car selected is displayed 

