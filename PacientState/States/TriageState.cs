using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class TriageState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.Triage, pacient.Name);
        }
    }
}