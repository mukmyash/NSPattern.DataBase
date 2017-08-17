using System;
using System.Collections.Generic;
using System.Text;

namespace NSPattern.DataBase.Transaction
{
    public interface IDatabaseTransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
