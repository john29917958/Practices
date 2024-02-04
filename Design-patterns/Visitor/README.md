Visitor
===

Scenario: When there potentially exists extension of operations to a group of objects under an inheritance tree. We need to visit through the group of objects to get summarized information or apply operations to them. The “operations” and the type of “elements” can be extended in the future without modifying each other, and the container class.

Pattern:
- A visitor’s inheritance tree, in which represents the extension of operation.
- An element structure’s inheritance tree, in which represents the extension of data.
- Visitors access every derived type of element structure data. When a new operation is needed, add a new concrete visitor class that implements / inherits the visitor’s interface


Example:
- Gets backpack loading by looping through all weapons and armors
- Removes every broken armors from backpack
- Drops any equipment from backpack, and creates specific effect for weapon and armor

![UML](UML.jpg)
