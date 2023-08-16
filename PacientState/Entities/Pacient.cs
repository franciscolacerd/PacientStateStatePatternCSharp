using PacientState.Contracts;
using PacientState.States;

namespace PacientState.Entities
{
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
}