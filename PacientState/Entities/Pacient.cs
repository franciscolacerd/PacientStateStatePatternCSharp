using PacientsState.Contracts;
using PacientsState.States;

namespace PacientsState.Entities
{
    public class Pacient
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public IPacientsState CurrentState { get; private set; }

        public Pacient(string name, int age)
        {
            this.Name = name;

            this.Age = age;

            this.CurrentState = new CheckInState();
        }

        public void ChangeState(IPacientsState newState)
        {
            this.CurrentState = newState;
        }

        public string GetCurrentState()
        {
            return this.CurrentState.ChangeState(this);
        }
    }
}