using Dapper;
using StockLink.Application.Dtos.CarritoCompra.Response;
using StockLink.Application.Interface.Interfaces;
using StockLink.Persistence.Context;
using System.Data;

namespace StockLink.Persistence.Repositories
{
    public class CarritoCompraRepository : ICarritoCompraRepository
    {
        private readonly Application2DbContext _context;

        public CarritoCompraRepository(Application2DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllCarritoCompraResponseDto>> GetAllCarritoByVendedor(string storedProcedure, object parameter)
        {
            using var connection = _context.CreateConnection;

            var objParam = new DynamicParameters(parameter);

            var carritoCompra = await connection.QueryAsync<GetAllCarritoCompraResponseDto>(storedProcedure, param: objParam, commandType: CommandType.StoredProcedure);
            return carritoCompra;
        }
    }
}
