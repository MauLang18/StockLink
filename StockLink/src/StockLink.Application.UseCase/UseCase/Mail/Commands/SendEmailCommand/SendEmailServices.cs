﻿using StockLink.Application.Interface.Interfaces;
using Microsoft.Extensions.Configuration;
using StockLink.Application.Dtos.Mail.Request;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace StockLink.Application.UseCase.UseCase.Mail.Commands.SendEmailCommand
{
    public class SendEmailServices : ISendEmailRepository
    {
        private readonly IConfiguration _configuration;

        public SendEmailServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(MailRequestDTO request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_configuration.GetSection("Email:UserName").Value));
            email.To.Add(MailboxAddress.Parse(request.Para));
            email.Subject = request.Asunto;
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = request.Contenido
            };

            using var smtp = new SmtpClient();
            smtp.Connect(_configuration.GetSection("Email:Host").Value,
                Convert.ToInt32(_configuration.GetSection("Email:Port").Value),
                SecureSocketOptions.StartTls);

            smtp.Authenticate(_configuration.GetSection("Email:UserName").Value,
                _configuration.GetSection("Email:PassWord").Value);

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
