using StockLink.Application.Interface.Interface;
using StockLink.Domain.Entities;

namespace StockLink.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<CarritoCompra> CarritoCompra { get; }

        public UnitOfWork(IGenericRepository<CarritoCompra> carritoCompra)
        {
            CarritoCompra = carritoCompra;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
