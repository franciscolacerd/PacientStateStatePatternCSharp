# Pacient State - State Pattern
State Pattern c# implementation of an Hospital pacient state

The State Pattern is used to manage the behavior of an object as its internal state changes. It defines a family of classes that represent various states and allows an object to change its behavior when its internal state changes. In this example, the IPacientState interface defines a method ChangeState to perform actions based on the patient's state. Concrete states like TriageState and MedicEvaluationState implement this interface to perform specific actions. The Pacient class holds a reference to the current state and delegates actions to it. This pattern promotes flexibility and simplifies the code by encapsulating each state's behavior.

------

The state pattern is a behavioral software design pattern that allows an object to alter its behavior when its internal state changes. This pattern is close to the concept of finite-state machines. The state pattern can be interpreted as a strategy pattern, which is able to switch a strategy through invocations of methods defined in the pattern's interface.

The state pattern is used in computer programming to encapsulate varying behavior for the same object, based on its internal state. This can be a cleaner way for an object to change its behavior at runtime without resorting to conditional statements and thus improve maintainability.

![State_Design_Pattern_UML](https://upload.wikimedia.org/wikipedia/commons/e/ec/W3sDesign_State_Design_Pattern_UML.jpg)

https://en.wikipedia.org/wiki/State_pattern

------
