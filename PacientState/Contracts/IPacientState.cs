using PacientsState.Entities;

namespace PacientsState.Contracts
{
    public interface IPacientsState
    {
        string ChangeState(Pacient pacient);
    }
}