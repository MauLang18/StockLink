using StockLink.Domain.Entities;

namespace StockLink.Application.Interface.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<CarritoCompra> CarritoCompra { get; }
    }
}
