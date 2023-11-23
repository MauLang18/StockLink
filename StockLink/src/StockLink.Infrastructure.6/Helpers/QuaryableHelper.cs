using StockLink.Infrastructure._6.Commons.Bases.Request;

namespace StockLink.Infrastructure._6.Helpers
{
    public static class QuaryableHelper
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePaginationRequest request)
        {
            return queryable.Skip((request.NumPage - 1) * request.Records).Take(request.Records);
        }
    }
}
