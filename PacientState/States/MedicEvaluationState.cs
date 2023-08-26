using PacientsState.Contracts;
using PacientsState.Entities;

namespace PacientsState.States
{
    public class MedicEvaluationState : IPacientsState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.MedicEvaluation, pacient.Name);
        }
    }
}