Template Method
===
Scenario: When there exists similar operation flow, the “implementation” of each operation can be different.

Pattern:
- Abstract class: A concrete method that defines flow of operation, executes all abstract methods in specific order
- Concrete class: Implements all operations

Example: Pre-checking flow of magic spell casting:
1. Checks if power value is enough
2. Checks if the cooling CD time is over
3. Checks if any target enemy is within attacking range <- This step can be different in different types of spell

![UML](UML.jpg)
