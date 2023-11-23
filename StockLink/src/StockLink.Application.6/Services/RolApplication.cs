using AutoMapper;
using StockLink.Application._6.Commons.Bases;
using StockLink.Application._6.Dtos.Rol.Request;
using StockLink.Application._6.Dtos.Rol.Response;
using StockLink.Application._6.Interfaces;
using StockLink.Domain._6.Entities;
using StockLink.Infrastructure._6.Commons.Bases.Request;
using StockLink.Infrastructure._6.Commons.Bases.Response;
using StockLink.Infrastructure._6.Persistences.Interfaces;
using StockLink.Utilities._6.Static;

namespace StockLink.Application._6.Services
{
    public class RolApplication : IRolApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<BaseEntityResponse<RolResponseDto>>> ListRoles(BaseFiltersRequest filters)
        {
            var response = new BaseResponse<BaseEntityResponse<RolResponseDto>>();
            try
            {
                var roles = await _unitOfWork.Rol.ListRoles(filters);

                if (roles is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<BaseEntityResponse<RolResponseDto>>(roles);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }

        public async Task<BaseResponse<IEnumerable<RolSelectResponseDto>>> ListSelectRol()
        {
            var response = new BaseResponse<IEnumerable<RolSelectResponseDto>>();
            try
            {
                var roles = await _unitOfWork.Rol.GetAllAsync();

                if (roles is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<IEnumerable<RolSelectResponseDto>>(roles);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }

        public async Task<BaseResponse<RolResponseDto>> RolById(int id)
        {
            var response = new BaseResponse<RolResponseDto>();
            try
            {
                var rol = await _unitOfWork.Rol.GetByIdAsync(id);

                if (rol is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<RolResponseDto>(rol);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }

        public async Task<BaseResponse<bool>> RegisterRol(RolRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var rol = _mapper.Map<TbRol>(requestDto);
                response.Data = await _unitOfWork.Rol.RegisterAsync(rol);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_SAVE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }

        public async Task<BaseResponse<bool>> EditRol(int id, RolRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var rolEdit = await RolById(id);

                if (rolEdit.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                var rol = _mapper.Map<TbRol>(requestDto);
                rol.Id = id;
                response.Data = await _unitOfWork.Rol.EditAsync(rol);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_UPDATE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }

        public async Task<BaseResponse<bool>> RemoveRol(int id)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var rol = await RolById(id);

                if (rol.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                response.Data = await _unitOfWork.Rol.RemoveAsync(id);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_DELETE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
            }

            return response;
        }
    }
}
