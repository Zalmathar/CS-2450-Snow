<!-- Tanis Olesen 09/12/2021 -->
# Chapter 4 Reading Notes

## Objectives:
* Understand user and system requirements, and in what ways requirements should be written.
* THe differences between functional and non-functional software requirements.
* Understand the activities of elicitation, analysis, and validation, and the relationships between these activities.
* understand why requirements management is necessary.


## Definitions: 

* Requirements for a system; The descriptions of services that a system should provide, including the constraints on its operation. 
  
* User Requirements, The user requirements may vary from broad statements, to system features, and possibly precise descriptions of the system functionality.

* System requirements, Should define exactly what is to be implemented, and may be part of the contract between system buyer and developers.

## 4.1 Functional and non-functional requirements

* Classified as functional and non - functional
   1. Functional requirements. Explicitly state what the system should or should not do. 
   2. Non-functional Requirements. Timing constraints, developments process, constraints, government regulation.

## 4.2 Requirements engineering processes
Three key activities
1. Elicitation and analysis, Discovery of requirements by interacting with stakeholders.
2. Specification, Convert the requirements into a standard form. (Documentation)
3. Validation, Check to make sure this is what the customer wants.

## 4.3 Requirements elicitation

### Difficult to elicit requirements because.
* Stakeholders do not know what they want other than a vague idea.
* Express requirements in their own terms, with implicit knowledge of their own work. You may not understand these requirements.
* With many people, they express their requirements in different ways.
* Office politics factor
* The business environment

### Process model, an iterative process: 

1. Requirements discovery and understanding. Get the requirements.
2. Requirements classification and organization, take related requirements and organize them into coherent clusters.
3. Requirements prioritization negotiation. Resolve requirements conflicts. 
4. Requirements documentation. Requirements are documented and and early draft of the software requirements is created.

### Requirements elicitation techniques:

#### Fundamental approaches to requirements elicitation:
* Interviewing, talk to people about what they do.
* Observation or ethnography, Watch people do their job to observe what artifacts they use, how they use them and so on.

#### Interviewing, may be of two types:
1. Open Interview. No predefined agenda. Team explores a range of issues with system stakeholders to develop a better understanding of needs.
2. Closed interview, where the stakeholder answers a predefined set of questions.

Interviews are not an effective way for eliciting knowledge about organizational requirements, and constraints. This is because often the internal politics and structure can often obscure the true structure of the organization. Especially to a stranger. To be an effective interviewer, bear two things in mind. 

1. Be open minded.
2. Use spring board question's or a requirements proposal. Possibly work together on a prototype system.

#### Ethnography, How the software interacts with the users of the system. Along with the social structure influencing it.
* Helps find implicit system requirements that reflect the ways people work, rather than the formal processes defined. It excels at discovering two types of requirements.
   1. Requirements derived from the way people actually work.
   2. Requirements derived from cooperation and awareness of other peoples activities.
* Combined with a system prototype, ethnography informs the developer of new, changed or non-functional requirements. It also helps to understand existing systems. 

#### Stories and scenarios
* It can be easier to relate to real-life examples than abstract descriptions. Although it might not be representative of what the system requirements are. 
* It is a description of how the system can be used for some particular tasks, Describing what people do, what information they use and produce, and what other systems they use.
* Generally, a scenario may include
   1. A description of what the system and users expect when the scenario starts.
   2. A description of the normal flow of event sin the scenario.
   3. A description of what can go wrong and how resulting problems can be handled. 
   4. Information about other activities that might be going ona the same time.
   5. A description of th system state when the scenario ends.

## 4.4 Requirements specification
* Is the process of writing down the user and system requirements in a requirements document.
* Written in natural language supplemented with diagrams and tables. 
* Describes the functional and non-functional requirements.
* Should not include details of the system architecture or design.
* Should not use software jargon, structured notations, or formal notation. It should be in a natural language.
* System requirements are expanded version of the user requirements. Adding detail and explain how the system should provide the user requirements. 
* The level of detail required to specify a complex software system you should not exclude any design information. There are several reasons for this: 
   1. You may have to create an initial architecture to help structure the requirements specification.
   2. In most cases systems must interoperate with existing systems, constraining the design imposing requirements on the new system. 
   3. The use of a specific architecture to satisfy non-functional requirements, may be necessary. Such as systems that have an external regulator.
* To minimize misunderstanding when writing in natural language.
   1. Invent a standard format and ensure all requirement definitions adhere to that format. Making omissions less likely and requirements easier to check. Typically in one or two sentences.
   2. Use language consistently to distinguish between mandatory and desirable requirements. Shall vs. Should
   3. Use text highlighting to pick out key parts of the requirement.
   4. Do not assume readers understand technical, software engineering language. avoid the use of jargon, abbreviations, and acronyms.
   5. Associate a rationale with each user requirement. Why the requirements has been included, who proposed it, so you can clarify from the source of the requirement.
### Structured Specifications
* When a standard format is used for specifying requirements the following info should be included
  1. A description of the function or entity being specified. 
  2. A description of its inputs and the origin of these inputs.
  3. A description of its outputs and the destination of these outputs.
  4. Information about the info need for the computation or other entities in the system that are required.
  5. A description of the action to be taken
  6. If a functional approach is used. A precondition setting out what must be true before the function is called. and a precondition specifying what is true after the function is called.
  7. A description of the side effects (if any) of the operation. 

### Use Cases
* A way of describing interactions between the users and system using a graphical model and structured text.
* Is a fundamental feature of the UML language. 

## 4.5 Requirements validation
* The process of checking that requirements define the system that the customer really wants.
* During the requirements validation process, different checks are carried out, these are:
  1. Validity checks
  2. Consistency checks
  3. completeness checks
  4. Realism checks
  5. Verifiability, Tests can be written for it.
* Requirements are validating using different techniques.
    1. Requirements reviews
    2. Prototyping
    3. Test-case generation

## 4.6 Requirements change

* Requirements for software systems are always changing. One reason for frequent changes is that systems are often developed to address problems that cannot be completely defined. Therefore are bound to be incomplete. 

* Some changes are due to the business environment of the system. For example
   1. The business and technical environment fo the system always changes after installation.
   2. The people who pay for a system and its users are rarely the same people. New features may have to be added for user support.
   3. Usually have a diverse stakeholder community. System requirements are inevitably a compromise, because of this priorities change.

* You need to keep track of individual requirements and maintain links between dependant requirements so you can asses the impact of changes. A formal process for making changes makes this easier.

* Requirements management planning, during the planning stage, you have to decide on a number of issues:
  1. Requirements identification
  2. A change management process, asses the impact and cost of changes.
  3. Traceability polices, what affects what.
  4. Tool support, The processing of large amount of information about the requirements. This tool should provide automated support. Making sure the software you choose has. Requirements storage, Change management, and traceability management.

Three principal stages to a change management process:
1. Problem analysis and change specification.
2. Change analysis and costing
3. Change implementation.
   
