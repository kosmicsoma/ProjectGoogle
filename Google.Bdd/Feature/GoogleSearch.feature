Feature: Google search functionality
As a prospect user 
I want to search Aviva 
So that I can get the relevant links

@positive
Scenario: Display number of search links related to Aviva 
	Given I am on Google search page
	When I enter "Aviva" in the search text box
	And click the Search Button
	Then I should see "5"th link text
	And I should see 6 links in th search page

@negative
Scenario: Display number of search links not related to Aviva 
	Given I am on Google search page
	When I enter "Aviva%123" in the search text box
	And click the Search Button
	Then I should see "5"th link text
	And I should not see 6 links in th search page