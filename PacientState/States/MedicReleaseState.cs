using PacientState.Contracts;
using PacientState.Entities;

namespace PacientState.States
{
    public class MedicReleaseState : IPacientState
    {
        public string ChangeState(Pacient pacient)
        {
            return $"Doing medic release to pacient {pacient.Name}";
        }
    }
}