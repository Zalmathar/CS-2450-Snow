<!-- Tanis Olesen 09/22/2021 -->
# Chapter 5 Reading Notes
## Objectives
* Understand how graphical models can be used to represent software systems and why several types of model are needed to fully represent a system.
* Understand the fundamental system modeling perspectives of context, interaction, structure, and behavior.
* Understand principal diagram types in UML, and how these diagrams may be used in system modeling.
* Introduced into model-driven engineering, where an executable system is automatically generated from structural and behavioral models.
  
### System Modeling
* The process of developing abstract models of a system, with different models presenting a different perspective. Usually done in UML, however it is also possible to develop formal (mathematical) models of a system.
* Models are used to help derive the requirements for a system. 
* When you are upgrading an already existing system it is useful to make models of both the existing system and the new system.
* You can generate a complete or partial system implementation from system models. Although it is not a complete representation of a system.
* Possible different Perspectives
    1. An external perspective. The context of a system.
    2. an interaction perspective. A model of the interactions between a system and its environment.
    3. A Structural perspective. Organization or structure of the data processed by the system.
    4. A Behavioral perspective. The dynamic behavior of the system and how it responds to events.
* Three ways in which graphical models are commonly used
    1. A way to stipulate and focus discussion about the proposed system. Covering key points of the discussion models are often incomplete.
    2. A way to document and existing system. Pan accurate description of the existing system.
    3. A detailed system description that can be used to generate a system implementation. Where models are used as part of a model-based development process. These models have to be both complete and correct. 
* UML is the standard diagram in OOP
* Five UML diagram types: 
    1. Activity diagram, the activities involved in a process. 
    2. Use case diagrams, show the interaction between a system and its environment.
    3. Sequence diagrams, show interactions between actors and the system.
    4. class diagrams, show the object classes in a system along with the associations between classes.
    5. State diagrams, how the system reacts to internal and external events.

## 5.1 Context models
* Decide on system boundaries, decide what is and is not part of a system being developed. Look at possible overlaps in functionality with existing systems. Decide where new functionality should be implemented.
* Social and organization concerns may mean that a position of system boundary may be determined by nontechnical factors.
* Figure out how the system will interact with the existing systems and external components to model system behavior.

## 5.2 Interaction Models
* All systems involve interaction, from user interaction, interaction between the new software and other systems; Interaction between the components of a software system. These models help identify requirements.
* Two related approaches to interaction modeling:
    1. Use case modeling. Model interactions between a system and external agents.
        * Can be taken as a simple description of what a user expects from a system interaction. Author finds use case models to be more useful in early stages of system design rather than in requirements engineering.
        * Each use cas represents a discrete task that involves external interaction with a system. Giving a simple overview of an interaction, needing more detail for complete interaction description.
        * Composite use case diagrams show a number of different use cases. Linking together multiple diagrams to better understand what a user expects from that interaction.
    2. Sequence Diagrams, model interactions between system components, external agents may also be included.
        * Primarily used to model interactions between actors and the objects in a system. Along with interactions between the objects themselves.
        * Unless you are using sequence diagrams for code generation or detailed documentation, you don't have to include every interaction in these diagrams. This is usually a high-level design, and many interactions will depend on implementation decisions.
* Multiple diagrams can be used together to represent deferent levels of detail.

## 5.3 Structural models
* Structural models display the organization of a system int terms of the components that make up a system, and their relationship's. These may be static models, showing the organization of the system design. Or dynamic models, which show the organization of the system when it is executing.
* You create structural models of a system when you are discussing and designing the system architecture. These can be models of the overall system architecture or more detailed models.
* Class diagrams are used to show the interaction between the classes in a system and the associations between these classes. Can be thought of as a general definition of one kind of system object. An association is a link between classes indicating a relationship.
* Class diagrams can be expressed at different levels of detail. First stage is usually to look at the world, identify the essential objects , and represent these as classes. at this level of detail, class diagrams look like semantic data models. The show the data entities, their associated attributes, and the relations between these entities. To define objects in more detail, add information about their attributes (the objects's characteristics) and operations. 
* Generalization is an everyday technique to manage complexity. Rather than learn the detailed characteristic of everything, we learn about general classes and learn the characteristics of them. We then reuse knowledge by classifying things and focus on the differences between them and their class.
* When modeling systems, examine the classes in a system to see if there is scope for generalization and class creation. Allowing for information to be consolidated. This follows along with aggregation. When one object is composed of other objects.
  
## 5.4 Behavioral models 
* Behavioral models model the dynamic behavior of a system while it is executing. Showing what happens or what is supposed to happen when an stimuli occurs. Either data or events:
    1. Data becomes available that needs to be processed. The availability of the data triggers the processing.
    2. An event happens that triggers system processing. Events may have associated data, although this is not always the case.
* Real-time systems are event driven. Data-processing systems are data driven.
  
### Data-Driven modeling
* Show the sequence of actions involved in processing input data and generating output data. Showing the entire sequence of actions.
* Data-Flow Diagrams (DFDs)
* DFDs can be represented in UML using the activity diagram type.
  
### Event-driven modeling
* Shows how a system responds to external and internal events. Based on the assumption that a system has a finite number of states.
* This view of a system is appropriate and used extensively for designing real-time system.
* UML supports event-based modeling using state diagrams, which are based on statechars.
   * These do not show the flow of data within the system, but the flow from one state to another.
   * May carry additional information on the computations carried out in each state.
* For large system models, you need to hide detail. This is done with using the notation of a **Superstate** that encapsulates a number of separate state.
  
### Model-driven engineering
* An approach to software development where models, rather than programs, are the principal outputs of the development process. 
* Used by some large companies to support their development process.
* Was developed from the idea of model-driven architecture.
  
## 5.5 Model-driven Architecture
A model-focused approach to software design and implementation using a subset of UML models to describe a system. To form a high-level, platform independent model. Three types of abstract system model should be produced
1. A *computation independent model* (CIM).
    * Model the important domain abstractions used in a system, 
    * You may develop several different CIMs, reflecting different views of the system.
2. A *platform-independent model*
    * Model the operation of the system without reference to its implementation.
    * Usually described using UML models that show the static system structure, showing how it responds to external and internal events.
3. *Platform-specific models*
    * Transformation of the platform-independent model to a separate PSM for each application platform, there may be layers of PSM, with each layer adding some platform specific detail.

Model-based engineering allows engineers to think about a system at a high level of abstraction, not concerned with the details of the implementation. Reducing the likely-hood of errors. In practice automated translation of models to code is rarely possible. 

* Translation of high-level CIM to PIM models remains a research problem. Requiring human intervention. 
* Translation of PIM to PSM models is a simpler technical problem. Using tools to convert the PSM model into executable code.
* These tools for translating require their own development for specific companies. Otherwise development requires additional manual coding reducing the cost-effectiveness of the approach.

Generally used to create well and understood applications and can be formalized into a CIM.