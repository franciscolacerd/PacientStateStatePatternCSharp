using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class CheckInState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.CheckIn, pacient.Name);
        }
    }
}