Feature: Controller

    Controles most of the games logic

Scenario: 
    Given The player is not jumpin
    And there are no obsticals
    When The frame is updated
    Then 

Scenario: Collision is detected
    Given There is a small rock
    And The rocks position is at (3, 1)
    When Collision is checked
    Then The game should end
