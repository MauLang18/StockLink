namespace StockLink.Infrastructure._6.Commons.Bases.Request
{
    public class BaseFiltersRequest : BasePaginationRequest
    {
        public int? NumFilter { get; set; } = null;
        public string? TextFilter { get; set; } = null;
        public bool? Download { get; set; } = false;

    }
}
