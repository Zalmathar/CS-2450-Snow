# Chapter 6 Reading Notes
## Objectives
* Understand wy the architectural design of software is important.
* Understand the decisions that have to be made about the software architecture during the architectural design process.
* Have been introduced to the idea of Architectural patterns, well-tried ways of organizing software architectures that can be reused in system designs. 
* Understand how Application-specific architectural patterns may be used in transaction processing and language processing systems. 

## Chapter Intro
Architectural design is concerned with understanding how a software system should be organized and designing the overall structure of that system.

In agile, an early stage of development should focus on designing an overall system architecture. Often there is significant overlap between the process of requirements engineering and architectural design. System specification should not include design information. You need to identify main architectural components that reflect high-level features of the system.

There are two levels of abstraction.
1. Architecture in the small
    * Concerned with the architecture of individual programs. We are concerned with the way that an individual program is decomposed into components. 
2. Architecture in the large
    * Concerned with the architecture of complex enterprise systems that include other systems. programs, and program components. These systems may be distributed over different computers, which may be owned and managed by different companies.

Architecture is important because it affects the performance, robustness, distributability and maintainability of a system. Non-functional requirements generally have the most impact on the systems architecture. Explicitly designing and documenting software architecture has three advantages.
1. Stakeholder communication
2. System analysis
3. Large-scale reuse

System architectures are often modeled informally using simple block diagrams, with each box representing a component. Boxes within boxes indicate that the component has been decomposed to sub components. These represent a high-level picture of the system structure. There are contradictions between architectural theory and industrial practice because there are two ways in which an architectural model is used. 
1. As a way of encouraging discussions about the system design.
2. As a way of documenting an architecture that has been designed. 

## 6.1 Architectural design decisions
Architectural design is a creative process in which you design a system organization that will satisfy the functional and non-functional requirements of a system. It is best to consider this design as a series of decisions to be made rather than a sequence of activities. When designing a system architecture, you have to decide what your system and broader application classes have in common, and decide how much knowledge from these application architectures you can reuse.

The architecture of a software system may be based on a particular architectural pattern or style. The patterns capture the essence of an architecture that has been used in different software systems. 

Fundamental architectural questions:
* Is there a generic application architecture that can act as a template for the system that is being designed?
* How will the system be distributed across hardware cores or processors?
* What architectural patterns or styles might be used?
* What will be the fundamental approach used to structure the system?
* What strategy will be used to control the operation of the components in the system?
* how will the structural components in the system be decomposed into sub-components?
* What architectural organization is best for delivering the non-functional requirements of the system?
* How should the architecture of the system be documented?

Because of the relationship between non-functional system characteristics and software architecture, the choice of architectural style and structure should depend on the non-functional requirements of the system. 
1. *Performance*, The architecture should be designed to localize critical operations within a small number of components.
2. *Security*, A layered structure for the architecture should be used, with the most critical assets protected in the innermost layers and a high level of security validation applied to these layers.
3. *Safety*, The architecture should be designed so that safety-related operations are co-located ina single component or in a small number of components. 
4. *Availability*, The architecture should be designed to include redundant components so that it is possible to replace and update components without stopping the system.
5. *Maintainability*, The system architecture should be designed using fine-grain, self-contained components that may readily be changed.

Evaluating a design is difficult because the true test of an architecture is how well the system meets its functional and non-functional requirements.

## 6.2 Architectural views
Four fundamental architectural views
1. A logical view, show the key abstractions in the system. (objects and classes)
2. A process view, shows how at runtime the system is composed of interacting processes. Useful for making judgments about non-functional system characteristics.   
3. A developmental view, show how the software is decomposed for development. Breakdown of the software into components that can be assigned to developers.
4. A physical view, Shows system hardware and how software components are distributed across the processors in the system.

An abstract view of the system can be the basis for decomposing high-level requirements into detailed specification. It is rarely necessary to develop a complete description from all perspectives.

## 6.3 Architectural patterns
Model-View-controller pattern, Separates presentation (view) and interaction (controller) from the system data. 

Layered architecture, Organize the system into layers, with related functionality associated with each layer. A layer provides services to the layer above it, so the lowest level layers represent core services that are likely to be used through the system. (OSI MODEL)

Repository, all data is managed in a central repository that is accessible to all system components. components do not interact directly, only through the repository.

Client-server, System is presented as a set of services, with each service delivered by a separate server. Clients are users of these services and access servers to make use of them. 

Pipe and filter architecture, Processing of data is organized so that each processing component is discrete and carries out one type of data transformation. Data flows from one component to another for processing.

## 6.4 Application Architectures

You can use models of application architectures in a number of ways.
1. A starting point for the architectural design process.
2. A design checklist
3. A way of organizing the work of the development team.
4. A means of assessing components for reuse.
5. As a vocabulary for talking about application.

