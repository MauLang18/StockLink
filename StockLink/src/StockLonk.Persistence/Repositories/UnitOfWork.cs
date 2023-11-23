using StockLink.Application.Interface.Interface;

namespace StockLink.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
