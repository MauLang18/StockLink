using Microsoft.AspNetCore.Mvc;
using StockLink.Application.Dtos.Mail.Request;
using StockLink.Application.Interface.Interfaces;

namespace StockLink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly ISendEmailRepository _sendEmailRepository;

        public MailController(ISendEmailRepository sendEmailRepository)
        {
            _sendEmailRepository = sendEmailRepository;
        }

        [HttpPost("Send")]
        public IActionResult SendEmail(MailRequestDTO requestDTO)
        {
            _sendEmailRepository.SendEmail(requestDTO);

            return Ok();
        }
    }
}
