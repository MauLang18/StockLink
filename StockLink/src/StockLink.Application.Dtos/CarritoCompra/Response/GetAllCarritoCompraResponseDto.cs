﻿namespace StockLink.Application.Dtos.CarritoCompra.Response
{
    public class GetAllCarritoCompraResponseDto
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? Vendedor { get; set; }
        public int Cantidad { get; set; }
    }
}
