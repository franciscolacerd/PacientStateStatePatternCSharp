using PacientState.Entities;

namespace PacientState.Contracts
{
    public interface IPacientState
    {
        string ChangeState(Pacient pacient);
    }
}