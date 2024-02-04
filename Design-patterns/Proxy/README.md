Proxy
===
Scenario: When we want to conditionally do something or add functionality to an existing object before its execution.

Pattern: Proxy object and real object inherits the same interface. The client uses the proxy object through the interface.

Examples:
- Conditionally enable caching of asset loader for A/B testing
- Show preview 3D model while the beautiful model is loading, and switch to real model after completely loaded.

![UML](UML.jpg)