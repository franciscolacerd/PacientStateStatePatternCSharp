using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class TriageState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing triage to pacient {pacient.Name}";
        }
    }
}