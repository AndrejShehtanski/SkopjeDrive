using SkopjeDrive.Models;

namespace SkopjeDrive.Services;

public interface IContactEmailSender
{
    Task SendAsync(ContactFormModel model, CancellationToken cancellationToken);
}
