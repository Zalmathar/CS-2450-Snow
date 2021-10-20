<!-- Tanis Olesen 10/01/2021 -->
# Chapter 7: Design and implementation Reading Notes
## Objectives
* Understand the most important activities in a general, object-oriented design process.
* Understand some of the different models that may be used to document an object-oriented design.
* Know about the idea of design patterns and how these are a way of reusing design knowledge and experience.
* Have been introduced to key issues that hae to be considered when implementing software, including software reuse and open-source development.

### Intro
Software design and implementation is the stage in the software engineering process where an executable software system is developed. Design and implementation are invariably interleaved. Design is about how to solve a problem, so there is always a design process. An important decision is weather to build or buy a software application. This chapter has two aims:
1. To show how system modeling and architectural design are put into practice in developing an object-oriented software design. 
2. To introduce important implementation issues that are not usually covered in programming books. These include software reuse, configuration management and open-source development.

## 7.1 Object-oriented design using the UML
To Develop a system design from concept to detailed, object-oriented design, you need to:
1. Understand and define the context and the external interaction with the system.
2. Design the system architecture. 
3. Identify the principal objects in the system.
4. develop design models. 
5. specify interfaces.

You develop a design by getting ideas, proposing solutions, and refining these solutions as information becomes available. Inevitable you have to backtrack and retry when problems arise.

### 7.1.1 System context and interactions
The first stage in software design process is to develop and understanding of the relationships between the software that is being designed and its external environment. Essential for deciding how to provide the required system functionality and how to structure the system to communicate with its environment. System context models and interaction models present complementary views of the relationships between a system and its environment.
1. A system context model is a structural model that demonstrates the other systems in the environment of the system being developed.
2. An interaction model is a dynamic model that shows how th system interacts with its environment as it is used.

### 7.1.2 Architectural design
Once you understand the big-picture and identified major components that make up the system and their interactions. You then design the system organization using an architectural pattern.

### 7.1.3 Object Class identification
Various ways of identifying object classes in object-oriented systems were suggested.
1. Use a grammatical analysis of a natural language description of the ystem to be constructed. Objects and attributes are nouns; operations or services are verbs.
2. Use tangible entities (things) in the application domain such as aircraft, roles such as manage ect...
3. Use scenario-based analysis where various scenarios of system use are identified and analyzed in turn. As each scenarios is analyzed, the team responsible for the analysis must identify the required objects, attributes, and operations.

In practice, you have to use several knowledge sources to discover object classes. At this stage you should focus on the objects themselves, without thinking about how these objects might be implemented. Once you have identified the objects, you then refine the object design. Looking for common features and then design the inheritance hierarchy for the system. 

### 7.1.4 Design models
These show the associations and relationships between these entities, and are the bridge between the system requirements and the implementation of a system. When you use UML to develop a design, you should develop two kinds of design model.
1. Structural models, describe the static structure of the system using object classes and their relationships. Important relationships that may be documented at this stage are generalization (inheritance) Relationships, uses/used-by relationships, and composition relationships.
2. Dynamic models describe the dynamic structure of the system and show the expected runtime interactions between the system objects. Interactions that may be documented include the sequence of service requests made by objects and the state changes triggered by these object interaction. 

Three UML model types are particularly useful for adding detail to seu case and architectural models.
1. Subsystem models, show logical groupings of objects into coherent subsystems. these are represented using a form of class diagram with each subsystem shown as a package with enclosed objects. Subsystem models are structural models.
2. Sequence models. show the sequence of object interactions. These are represented using a UML sequence or a collaboration diagram.
3. State machine models, show how objects change their state in response to events. These are represented in the UMl using state diagrams. State machine models are dynamic models.

### 7.1.5 Interface Specification
Once an interface has been specified, the developers of other objects may assume that interface will be implemented.Interface design is cornered with specifying the detail of the interface to an object or to a group of objects. You shold not include details of the state representation in an interface design. 


## 7.2 Design Patterns
Patterns and Pattern Languages are ways to describe best practices, good designs, and capture experience ina way that it is possible for others to reuse this experience. There are four essential elements of design patterns.
1. A name that is meaningful reference to the pattern. 
2. A description of the problem area that explains when the pattern may be applied. 
3. A solution description of the parts of the design solution, their relationships and their responsibilities. This is not a concrete design description. It is a template for a design solution that can be instantiated in different ways. This is often expressed graphically and shows the relationships between the objects and object classes in the solution.
4. A Statement of the consequences, the results and trade-offs, of applying the pattern. This can help designers understand whether or not a pattern can be used in a particular situation. 

Patterns mentioned in book: 
1. Observer pattern. Tell several objects that the state of some other object has changed.
2. Facade pattern, Tidy up the interfaces to a number of related objects that have often been developed incrementally.
3. Iterator pattern, Provide a standard way of accessing the elements ina collection, irrespective of how that collection is implemented.
4. Decorator pattern, Allow for the possibility of extending the functionally of an existing class at runtime.


## 7.3 Implementation issues
there are some aspects of implementation that are particularly important to software engineering. 
1. Reuse, most modern software is constructed by reusing existing components of systems. When you are developing software, you should make as much use as possible of existing code. Software reuse is possible at a number of different levels:
   1. The Abstraction Level, At this level, you don't reuse software directly but rather use knowledge of successful abstractions in the design of your software. 
   2. The Object level, you directly reuse objects from a library rather than writing the code yourself.
   3. The Component level, are collections of objects and object classes that operate together to provide related functions and services. Often have to adapt and extend the component by adding some code of your own.
   4. System level, You reuse entire application systems. 
2. Configuration management, During the development process, many different versions of each software component are created. If you don't keep track of these versions in a configuration management system, you a reliable to include the wrong versions of these components in you system. There are four configuration management activities.
   1. Version management. (think git)
   2. System integration, Where support is provided to help developers define what versions of components are used to create each version of a system. This description is then used to build a system automatically by compiling and linking the required components. 
   3. Problem tracking, where support is provided to allow users to report bugs and other problems, and to allow all developers to see who is working on these problems and when they are fixed.
   4. Release management, where new version of a software system are released to customers. Release management is concerned with planning the functionality of new releases and organizing the software for distribution. 
3. Host-Target development, Production software does not usually execute on the same computer as the software development environment. Rather, you develop it on one computer (the host system) and execute it on a separate computer (the target system). The host and target systems are sometimes of the same type, but often they are completely different.
   1. 

## 7.4 Open-source development