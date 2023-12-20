using AutoMapper;
using StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.CreateCommand;
using StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.UpdateCommand;
using StockLink.Domain.Entities;

namespace StockLink.Application.UseCase.Mapping
{
    public class CarritoCompraMappingProfile : Profile
    {
        public CarritoCompraMappingProfile()
        {
            CreateMap<CreateCarritoCompraCommand, CarritoCompra>();

            CreateMap<UpdateCarritoCompraCommand, CarritoCompra>();
        }
    }
}
