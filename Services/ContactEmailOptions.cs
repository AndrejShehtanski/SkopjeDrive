namespace SkopjeDrive.Services;

public sealed class ContactEmailOptions
{
    public const string SectionName = "ContactEmail";

    public string Host { get; set; } = "";
    public int Port { get; set; } = 587;
    public bool EnableSsl { get; set; } = true;
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string FromName { get; set; } = "";
    public string RecipientAddress { get; set; } = "";
}
