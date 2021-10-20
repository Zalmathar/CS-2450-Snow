<!-- Tanis Olesen Chapter 8 Homework 10/8/2021 -->
# Chapter 8 Homework | Tanis Olesen
> 8.2 Explain why testing can only detect the presence of errors, not their absence.

Tests can only check for things that you have specified in the test. If you did not specify a particular area to test it could be producing errors that are not automatically checked for accuracy.

> 8.4 You have been asked to test a method called catWhiteSpace in a "Paragraph" object that, within the paragraph, replaces sequences of blank characters with a single blank character. Identify testing partitions for this example and derive a set of tests for the catWhiteSpace method.

```c#
[Test]
public void catWhiteSpaceTest() 
{
    debug.Assert(catWhiteSpace("This  Has  Two  Spaces") == "This Has Two Spaces");
    debug.Assert(catWhiteSpace("Five     Spaces") == "Five Spaces");
    debug.Assert(catWhiteSpace("   Before") == " Before");
    debug.Assert(catWhiteSpace("after    ") == "after ");
    debug.Assert(catWhiteSpace("   Before   and   after   ") == " Before and after ");
    debug.Assert(catWhiteSpace("                                                    ") == " ");
    debug.Assert(catWhiteSpace("") == "");
}
```

> 8.5 What is regression testing? Explain how the use of automated tests and a testing framework such as SpecFlow simplifies regression testing.

Regression testing is ensuring that any changes that are made to a new version of code, does not break anything previously implemented. Automated testing simplifies this by having all of your test run each time a change is made to the code, ensuring other parts do not break when you add, change, or refactor code.

> 8.7 Write a scenario that could be used to help design tests for the wilderness weather station system.

```SpecFlow
Feature: WeatherStation

    Collects information about the current weather 

Background: Report Weather
    Given the following weather statistics
        | Sensor        | Value   |
        | temperature   | 35 F    |
        | windSpeed     | 4 mph   |
        | humidity      | 5%      |

Scenario: Report the weather
    When I call the method 'reportWeather()'
    Then The weather details should show
        | Sensor        | Value   |
        | temperature   | 35 F    |
        | windSpeed     | 4 mph   |
        | humidity      | 5%      |
```

> 8.8 What do you understand by the term stress testing? Suggest how you might stress-test the mentcare system.

Stress testing is to find the limits of your software, we are trying to find the straw that breaks the camels back. You could stress test the mentcare system by creating virtual machines that are all trying to connect and access data from the system.

> 8.9 What are the benefits of involving users in release testing at an early stage in the testing process? Are there disadvantages in user involvement. 

By having users involved early on in the testing process they can help this the requirements engineering process. Ensuring that features that are added are the correct ones, and ensuring they work how the customer wants it. It would also help by seeing how a user interacts with your system. A disadvantage is that in the early stages the software could change very rapidly, creating confusion from the users as to what was added and changed.