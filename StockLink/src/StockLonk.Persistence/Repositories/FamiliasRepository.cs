using Dapper;
using StockLink.Application.Dtos.Articulo.Response;
using StockLink.Application.Dtos.Familia.Response;
using StockLink.Application.Interface.Interface;
using StockLink.Persistence.Context;
using System.Data;

namespace StockLink.Persistence.Repositories
{
    public class FamiliasRepository : IFamiliasRepository
    {
        private readonly ApplicationDbContext _context;

        public FamiliasRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetAllFamiliaResponseDto>> GetAllFamilias(string storedProcedure, object parameter)
        {
            using var connection = _context.CreateConnection;

            var objParam = new DynamicParameters(parameter);

            var familias = await connection.QueryAsync<GetAllFamiliaResponseDto>(storedProcedure, param: objParam, commandType: CommandType.StoredProcedure);
            return familias;
        }
    }
}
