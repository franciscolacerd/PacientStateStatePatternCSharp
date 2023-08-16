# Pacient State - State Pattern
State Pattern c# implementation of an Hospital pacient state

The State Pattern is used to manage the behavior of an object as its internal state changes. It defines a family of classes that represent various states and allows an object to change its behavior when its internal state changes. In this example, the IPacientState interface defines a method ChangeState to perform actions based on the patient's state. Concrete states like TriageState and MedicEvaluationState implement this interface to perform specific actions. The Pacient class holds a reference to the current state and delegates actions to it. This pattern promotes flexibility and simplifies the code by encapsulating each state's behavior.

------

The state pattern is a behavioral software design pattern that allows an object to alter its behavior when its internal state changes. This pattern is close to the concept of finite-state machines. The state pattern can be interpreted as a strategy pattern, which is able to switch a strategy through invocations of methods defined in the pattern's interface.

The state pattern is used in computer programming to encapsulate varying behavior for the same object, based on its internal state. This can be a cleaner way for an object to change its behavior at runtime without resorting to conditional statements and thus improve maintainability.

![State_Design_Pattern_UML](https://upload.wikimedia.org/wikipedia/commons/e/ec/W3sDesign_State_Design_Pattern_UML.jpg)

https://en.wikipedia.org/wiki/State_pattern

------

## C# Implementation

### 1. Declare Hospital entities 

#### Pacient
```c#
  public class Pacient
  {
      public string Name { get; private set; }

      public int Age { get; private set; }

      public IPacientState CurrentState { get; private set; }

      public Pacient(string name, int age)
      {
          this.Name = name;

          this.Age = age;

          this.CurrentState = new CheckInState();
      }

      public void ChangeState(IPacientState newState)
      {
          this.CurrentState = newState;
      }

      public string GetCurrentState()
      {
          return this.CurrentState.ChangeState(this);
      }
  }
```

### 2. Declare the state interface
```c#
    public interface IPacientState
    {
        string ChangeState(Pacient pacient);
    }
```

### 3. Declare concrete state subclasses

#### CheckInState
```c#
    public class CheckInState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing checkin to pacient {pacient.Name}";
        }
    }
```

#### TriageState
```c#
    public class TriageState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing triage to pacient {pacient.Name}";
        }
    }
```

...MedicEvaluationState, MedicReleaseState.

### 5. Unit test it

```c#
    public class PacientStateUnitTests
    {
        private Pacient _pacient;

        [SetUp]
        public void Setup()
        {
            this._pacient = new Pacient("francisco lacerda", 45);
        }

        [Test]
        public void Should_ChangePacientToTriage_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing checkin to pacient francisco lacerda");

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing triage to pacient francisco lacerda");
        }
    }
```