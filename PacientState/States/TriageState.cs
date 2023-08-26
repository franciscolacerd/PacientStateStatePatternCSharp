using PacientsState.Contracts;
using PacientsState.Entities;

namespace PacientsState.States
{
    public class TriageState : IPacientsState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.Triage, pacient.Name);
        }
    }
}