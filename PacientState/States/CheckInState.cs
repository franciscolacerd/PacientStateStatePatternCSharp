using PacientsState.Contracts;
using PacientsState.Entities;

namespace PacientsState.States
{
    public class CheckInState : IPacientsState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.CheckIn, pacient.Name);
        }
    }
}