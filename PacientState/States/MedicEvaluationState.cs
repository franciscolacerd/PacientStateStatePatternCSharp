using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class MedicEvaluationState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing medic evaluation to pacient {pacient.Name}";
        }
    }
}