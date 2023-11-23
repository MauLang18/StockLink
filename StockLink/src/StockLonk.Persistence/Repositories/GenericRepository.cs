﻿using Dapper;
using StockLink.Application.Interface.Interface;
using StockLink.Persistence.Context;
using System.Data;

namespace StockLink.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string storedProcedure)
        {
            using var connection = _context.CreateConnection;

            return await connection
                .QueryAsync<T>(storedProcedure, commandType: CommandType.StoredProcedure);
        }

        public async Task<T> GetByIdAsync(string storedProcedure, object parameter)
        {
            using var connection = _context.CreateConnection;

            var objParam = new DynamicParameters(parameter);

            return await connection
                .QuerySingleOrDefaultAsync<T>(storedProcedure, param: objParam, commandType: CommandType.StoredProcedure)!;
        }

        public async Task<bool> ExecAsync(string storedProcedure, object parameters)
        {
            using var connection = _context.CreateConnection;

            var objParam = new DynamicParameters(parameters);

            var recordsAffected = await connection
                .ExecuteAsync(storedProcedure, param: objParam, commandType: CommandType.StoredProcedure);

            return recordsAffected > 0;
        }
    }
}
