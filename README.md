# Pacient State - State Pattern
State Pattern c# implementation of an Hospital pacient state

The State Pattern is used to manage the behavior of an object as its internal state changes. It defines a family of classes that represent various states and allows an object to change its behavior when its internal state changes. In this example, the IPacientState interface defines a method ChangeState to perform actions based on the patient's state. Concrete states like TriageState and MedicEvaluationState implement this interface to perform specific actions. The Pacient class holds a reference to the current state and delegates actions to it. This pattern promotes flexibility and simplifies the code by encapsulating each state's behavior.

------

![State_Design_Pattern_UML](https://upload.wikimedia.org/wikipedia/commons/e/ec/W3sDesign_State_Design_Pattern_UML.jpg)

https://en.wikipedia.org/wiki/State_pattern

------
