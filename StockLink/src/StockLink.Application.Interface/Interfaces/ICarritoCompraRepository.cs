using StockLink.Application.Dtos.CarritoCompra.Response;

namespace StockLink.Application.Interface.Interfaces
{
    public interface ICarritoCompraRepository
    {
        Task<IEnumerable<GetAllCarritoCompraResponseDto>> GetAllCarritoByVendedor(string storedProcedure, object parameter);
    }
}
