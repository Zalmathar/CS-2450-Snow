Feature: WeatherStation

    Collects information about the current weather 

Background: Report Weather
    Given the following weather statistics
        | Sensor        | Value   |
        | tempurature   | 35 F    |
        | windSpeed     | 4 mph   |
        | humidity      | 5%      |

Scenario: Report the weather
    When I call the method 'reportWeather()'
    Then The weather details should show
        | Sensor        | Value   |
        | tempurature   | 35 F    |
        | windSpeed     | 4 mph   |
        | humidity      | 5%      |