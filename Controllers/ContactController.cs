using Microsoft.AspNetCore.Mvc;
using SkopjeDrive.Models;
using SkopjeDrive.Services;

namespace SkopjeDrive.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactEmailSender _emailSender;
        private readonly ILogger<ContactController> _logger;

        public ContactController(
            IContactEmailSender emailSender,
            ILogger<ContactController> logger)
        {
            _emailSender = emailSender;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactFormModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(
            ContactFormModel model,
            CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await _emailSender.SendAsync(model, cancellationToken);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "The contact form email could not be sent.");
                ModelState.AddModelError(
                    string.Empty,
                    "ContactSendError");
                return View(model);
            }

            TempData["ContactSuccess"] = true;
            return RedirectToAction(nameof(Index));
        }
    }
}
