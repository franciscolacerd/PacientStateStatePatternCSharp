using PacientState.Entities;

namespace PacientState.Contracts
{
    public interface IPacientState
    {
        //DoWork
        string ChangeState(Pacient pacient);
    }
}