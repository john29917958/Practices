Decorator
===
Scenario: When a function of a stable system needs to be enhanced, and the enhancement is somehow like superimposing new ability to existing feature, then the decorator design pattern can be a good choice.

Pattern: There are two chains under the inheritance family. One is the concrete entity chain, and the other is the pseudo decoration chain in which all objects hold a reference to the base interface. The concrete entity chain represents the functionality; While the pseudo decoration chain represents the enhancements.

Example:
- The buff applied to character (maybe from weapon, armor, or spell)
- To add pearl, konjac, taro, herbal jelly into the drink. Additional cost is required for each seasoning

![UML](UML.jpg)
