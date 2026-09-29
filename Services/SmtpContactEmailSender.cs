using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using SkopjeDrive.Models;

namespace SkopjeDrive.Services;

public sealed class SmtpContactEmailSender : IContactEmailSender
{
    private readonly ContactEmailOptions _options;

    public SmtpContactEmailSender(IOptions<ContactEmailOptions> options)
    {
        _options = options.Value;
    }

    public async Task SendAsync(
        ContactFormModel model,
        CancellationToken cancellationToken)
    {
        EnsureConfigured();

        using var message = new MailMessage
        {
            From = new MailAddress(_options.FromAddress, _options.FromName),
            Subject = $"New website message from {HeaderSafe(model.Name)}",
            Body = BuildBody(model),
            IsBodyHtml = false
        };

        message.To.Add(new MailAddress(_options.RecipientAddress));
        message.ReplyToList.Add(new MailAddress(model.Email, HeaderSafe(model.Name)));

        using var client = new SmtpClient(_options.Host, _options.Port)
        {
            EnableSsl = _options.EnableSsl,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(_options.Username, _options.Password)
        };

        await client.SendMailAsync(message, cancellationToken);
    }

    private void EnsureConfigured()
    {
        if (string.IsNullOrWhiteSpace(_options.Host) ||
            string.IsNullOrWhiteSpace(_options.Username) ||
            string.IsNullOrWhiteSpace(_options.Password) ||
            string.IsNullOrWhiteSpace(_options.FromAddress) ||
            string.IsNullOrWhiteSpace(_options.RecipientAddress))
        {
            throw new InvalidOperationException(
                "Contact email is not configured. Set ContactEmail settings, including the password.");
        }
    }

    private static string BuildBody(ContactFormModel model)
    {
        var phone = string.IsNullOrWhiteSpace(model.Phone) ? "Not provided" : model.Phone.Trim();

        return $"""
            A new message was submitted through the Skopje Drive website.

            Name: {model.Name.Trim()}
            Email: {model.Email.Trim()}
            Phone: {phone}

            Message:
            {model.Message.Trim()}
            """;
    }

    private static string HeaderSafe(string value) =>
        value.Replace("\r", " ").Replace("\n", " ").Trim();
}
