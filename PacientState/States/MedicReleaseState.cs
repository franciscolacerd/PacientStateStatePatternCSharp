using PacientsState.Contracts;
using PacientsState.Entities;

namespace PacientsState.States
{
    public class MedicReleaseState : IPacientsState
    {
        public string ChangeState(Pacient pacient)
        {
            return string.Format(Entities.States.MedicRelease, pacient.Name);
        }
    }
}