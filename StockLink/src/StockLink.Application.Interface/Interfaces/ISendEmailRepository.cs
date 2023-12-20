using StockLink.Application.Dtos.Mail.Request;

namespace StockLink.Application.Interface.Interfaces
{
    public interface ISendEmailRepository
    {
        void SendEmail(MailRequestDTO request);
    }
}
