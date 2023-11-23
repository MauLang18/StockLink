using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Infrastructure._6.Persistences.Interfaces
{
    public interface IRolRepository : IGenericRepository<TbRol>
    {
        Task<BaseEntityResponse<TbRol>> ListRoles(BaseFiltersRequest filters);
    }
}
