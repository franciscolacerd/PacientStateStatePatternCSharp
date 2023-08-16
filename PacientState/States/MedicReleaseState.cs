using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class MedicReleaseState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.MedicRelease, pacient.Name);
        }
    }
}