using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;

namespace StockLink.Infrastructure._6.Persistences.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<TbUsuario>
    {
        Task<BaseEntityResponse<TbUsuario>> ListUsuarios(BaseFiltersRequest filters);
        Task<TbUsuario> UserByUser(string user);
    }
}
