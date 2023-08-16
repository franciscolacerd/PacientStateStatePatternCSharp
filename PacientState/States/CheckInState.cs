using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class CheckInState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing checkin to pacient {pacient.Name}";
        }
    }
}