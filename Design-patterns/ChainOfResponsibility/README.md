Chain of Responsibility
===

Scenario: When a request can be conditionally accepted and handled by a series of handlers.

Pattern: A handler knows the next handler with the same interface.

Remark:
- Can be stoppable and non-stoppable
- Unlike state machine, there’s only a single request flow in the chain of responsibility

Examples:
- Game stages
- The document signing process in a company

![UML](UML.jpg)
