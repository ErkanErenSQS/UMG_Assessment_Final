Feature: SignUpFeatureSteps

@StepBindings
Scenario: Create a new account
	Given I am not logged in
	When I complete the signup form
	Then i am logged in
	Then username is displayed