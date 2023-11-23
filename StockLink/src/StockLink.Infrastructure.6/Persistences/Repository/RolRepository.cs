using Microsoft.EntityFrameworkCore;
using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;
using StockLink.Infrastructure._6.Persistences.Contexts;
using StockLink.Infrastructure._6.Persistences.Interfaces;

namespace StockLink.Infrastructure._6.Persistences.Repository
{
    public class RolRepository : GenericRepository<TbRol>, IRolRepository
    {
        private readonly USUARIOSContext _context;
        public RolRepository(USUARIOSContext context) : base(context)
        {
            _context = context;
        }

        public async Task<BaseEntityResponse<TbRol>> ListRoles(BaseFiltersRequest filters)
        {
            var response = new BaseEntityResponse<TbRol>();

            var usuarios = GetEntityQuery(x => x.Id != 0 && x.Rol != null)
                .AsNoTracking();

            if (filters.NumFilter is not null && !string.IsNullOrEmpty(filters.TextFilter))
            {
                switch (filters.NumFilter)
                {
                    case 1:
                        usuarios = usuarios.Where(x => x.Rol!.Contains(filters.TextFilter));
                        break;
                }
            }

            if (filters.Sort is null) filters.Sort = "Id";

            response.TotalRecords = await usuarios.CountAsync();
            response.Items = await Ordering(filters, usuarios, !(bool)filters.Download!).ToListAsync();

            return response;
        }
    }
}
