using StockLink.Application.Dtos.Cliente.Response;

namespace StockLink.Application.Interface.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<GetAllClienteResponseDto>> GetAllClientes(string storedProcedure, object parameter);
    }
}