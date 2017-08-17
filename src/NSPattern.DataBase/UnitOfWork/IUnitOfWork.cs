using NSPattern.DataBase.Transaction;

namespace NSPattern.DataBase.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDatabaseTransaction BeginTransaction(IsolationLevel level = IsolationLevel.ReadCommitted);
    }
}
