using Dapper;
using StockLink.Application.Dtos.Cliente.Response;
using StockLink.Application.Interface.Interfaces;
using StockLink.Persistence.Context;
using System.Data;

namespace StockLink.Persistence.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllClienteResponseDto>> GetAllClientes(string storedProcedure, object parameter)
        {
            using var connection = _context.CreateConnection;

            var objParam = new DynamicParameters(parameter);

            var clientes = await connection.QueryAsync<GetAllClienteResponseDto>(storedProcedure, param: objParam, commandType: CommandType.StoredProcedure);
            return clientes;
        }
    }
}
