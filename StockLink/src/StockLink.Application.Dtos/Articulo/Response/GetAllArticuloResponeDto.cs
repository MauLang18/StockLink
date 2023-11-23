namespace StockLink.Application.Dtos.Articulo.Response
{
    public class GetAllArticuloResponseDto
    {
        public string? Codigo { get; set; }
        public string? CodigoProveedor { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public decimal? CantidadDisponible { get; set; }
    }
}
