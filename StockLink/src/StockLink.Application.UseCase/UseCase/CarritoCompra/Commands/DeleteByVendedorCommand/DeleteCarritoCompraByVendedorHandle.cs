﻿using AutoMapper;
using MediatR;
using StockLink.Application.Interface.Interface;
using StockLink.Application.UseCase.Commons.Bases;
using StockLink.Utilities.Constants;
using Entity = StockLink.Domain.Entities;

namespace StockLink.Application.UseCase.UseCase.CarritoCompra.Commands.DeleteByVendedorCommand
{
    public class DeleteCarritoCompraByVendedorHandle : IRequestHandler<DeleteCarritoCompraByVendedorCommand, BaseResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteCarritoCompraByVendedorHandle(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<bool>> Handle(DeleteCarritoCompraByVendedorCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();

            try
            {
                response.Data = await _unitOfWork.CarritoCompra.ExecAsync(SP.paDeleteCarritoCompraByVendedor, request);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = GlobalMessage.MESSAGE_DELETE;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
