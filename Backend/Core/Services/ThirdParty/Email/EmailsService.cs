﻿using Data.Helpers;
using MailKit.Net.Smtp;
using MimeKit;
namespace Core.Services.ThirdParty.EmailService;

public class EmailsService : IEmailsService
{
    #region Fields
    private readonly EmailSettings _emailSettings;
    #endregion
    #region Constructors
    public EmailsService(EmailSettings emailSettings)
    {
        _emailSettings = emailSettings;
    }

    #endregion
    #region Handle Functions
    public async Task<string> SendEmail(string email, string Message, string? reason)
    {
        try
        {
            //sending the Message of passwordResetLink
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_emailSettings.Host, _emailSettings.Port, true);
                client.Authenticate(_emailSettings.FromEmail, _emailSettings.Password);
                var bodybuilder = new BodyBuilder
                {
                    HtmlBody = $"{Message}",
                    TextBody = "wellcome",
                };
                var message = new MimeMessage
                {
                    Body = bodybuilder.ToMessageBody()
                };
                message.From.Add(new MailboxAddress("Real Estate Application", _emailSettings.FromEmail));
                message.To.Add(new MailboxAddress(email, email));
                message.Subject = reason == null ? "No Submitted" : reason;
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            //end of sending email
            return "Success";
        }
        catch (Exception ex)
        {
            return "Failed";
        }
    }
    #endregion
}
