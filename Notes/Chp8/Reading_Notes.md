<!-- Tanis Olesen Chapter 8 Reading Notes 10/06/2021 -->
# Chapter 8 Reading Notes
### Objectives
* Understand the stages of testing from testing during development to acceptance testing by system customers
* Have been introduced to techniques that help you choose test cases that are geared to discovering program defects
* understand test-first development, where you design tests before writing code and run these tests automatically.
* know about three distinct types of testing - component testing, system testing and release testing
* understand the distinctions between development testing and user testing.

### Introduction
When you test software, you are trying to do two things
1. Validation testing, Demonstrate to the developer and the customer that the software meets its requirements. 
2. Defect Testing, Find inputs or input sequences where the behavior of the software is incorrect, undesirable, or does not conform to its specification. Caused by defects (bugs) in the software. 

Testing can only show the presence of errors, not their absence.

Validation: Are we building the right Product?

Verification: Are we building the product right? 

Verification and validation processes are concerned with checking that software being developed meets its specification and delivers the functionality expected by the people paying for the software. These checking processes start as soon as requirements become viable and continue through all stages of the development process. The level of required confidence depends on the system's purpose, the expectations of the system users, and the current marketing environment for the system.

1. Software purpose, the more critical the software, the more important it is that it is reliable. For example, the level of confidence required for software used to control a safety-critical system is mich higher than that required for a demonstrator system that prototypes new product ideas.
2. User Expectations, Because of their previous experiences with buggy, unreliable software, users sometimes have low expectations of software quality. They are not surprised when their software fails. 
3. Marketing environment, When a software company bring a system to market, it must take into account competing products, the price that customers are willing to pay for a system, and the required schedule for delivering that system. In a competitive environment. the Company may decide to release a program before it has been fully tested and debugged because it wants to bbe the first into the market. If a software product or app is very cheap, users may be willing to tolerate a lower level orf reliability.

As well as software testing, the verification and validation process may involve software inspections and reviews.

1. During testing, errors can mask other errors.
2. Incomplete versions of a system can be inspected without additional costs.
3. As wall as searching for program defects, an inspection can also consider broader quality attributes of a program, such as compliance, portability, and maintainability.

However inspections cannot replace software testing.

Typically, a software system has to go through three stages of testing.
1. Development testing,
2. Release testing
3. User testing.

## 8.1 Development Testing
Three stages of development testing
1. Unit testing, where individual program units, or object classes are tested. unit testing should focus of on testing the functionality of objects or methods.
    * When you are testing object classes. you should design your tests to provide coverage of all of the features of the object. This means that you should test all operations associated with the object; set and check the value of all attributes associated with the object, and put the object into all possible states. This means you should simulate all event that cause a state change.
    * An automated test has three parts:
        1. A setup part, where you initialize the system with the test case, namely, the inputs and expected outputs.
        2. A call part, where you call the object or method to be tested.
        3. An assertion part, where you compare the result of the call with the expected result. If the assertion evaluates to true, the test has been successful, if false, then it has failed.
    * It is important that you choose effective unit test cases. The test cases should show that, when used a s expected, the component that you are testing does what it is supposed to do. If there are defects in the component, these should be revealed by test cases. You should therefore design two kinds of test case. The first should reflect normal operation of a program, showing how the components work. The other test case should be based ton testing experience of where common problems arise. It should use abnormal inputs to check that these are properly processed and do not crash the component.

    1. Test software with sequences that have only a single value.
    2. Use different sequences of different sizes in different tests.
    3. Derive tests so that the first, middle, and last elements of the sequence are accessed.
2. Component Testing, where several individual units are integrated to create composite components. Component testing should focus on testing the component interfaces that provide access to the component functions.
    * There are different types of interface between program components and, consequently, different types of interface error that can occur:
        1. Parameter interfaces, the interfaces in which data or sometimes function references are passed from one component ot another. Methods in an object have a parameter interface.
        2. Shared memory interfaces, These are interfaces in which a block of memory is shared between components. Data is placed in the memory by one subsystem and retrieved from there by other subsystems. This type of interface is used in embedded systems, where sensors create data that is retrieved and processed by other system components. 
        3. Procedural interfaces these are interfaces in which one component encapsulates a set of procedures that can be called by other components. Objects and reusable components have this form of interface.
        4. Message passing interfaces, These are interfaces in which one component requests a service from another component by passing a message to it. A return message includes the result's of executing the service. Som object-oriented systems have this form of interface, as do client-server systems. 
3. System testing. Where some or all of the components in a system are integrated and the system is tested as a whole. System testing should focus on testing component interactions.
   1. During system tesgin, reuable components that have been sperately developed and off-the-shelf systems mya be integrated with nely developed components. The compolete system is then used.


## 8.2 Test-driven development
1. Code coverage, In principle, every code segment that you write should have at least one associated test.
2. Regression testing, A test suite is developed incrementally as a program is developed.
3. Simplified debugging. When a test fails, it should be obvious where the problem lies. The newly written code needs to be checked and modified.
4. System documentation. The tests themselves act as a form of documentation that describe what the code should be doing. Reading thee tests can make it easier to understand the code.


## 8.3 Release testing
Release testing is testing a particular release of a system that is intended for use outside of the development team. There are two important distinctions between release testing and system testing:
1. The system dev team should not be responsible for release testing.
2. Release testing is a process of validation checking to ensure that a system meets its requirements and is good enough for use by system customers.



## 8.4 User testing
Three types:

1. Alpha testing, where a selected group of software users work closely wit the dev team to test early releases of the software.
2. beta testing, Software is made available to a larger group of users to allow them to experiment and to raise problems that they discover with the system developers.
3. acceptance testing, where customers test a system to decice wether or not it is ready to be accepted form tht system developers and deployed in the custoer environment.

Six stages of acceptance testing
1. Define acceptance criteria
2. Plan acceptance testing
3. derive ac cceptance tests
4. Run acceptance tests
5. Negotiate test results
6. Reject/accept system

