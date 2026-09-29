using System.ComponentModel.DataAnnotations;

namespace SkopjeDrive.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "ContactValidationNameRequired")]
        [StringLength(100, ErrorMessage = "ContactValidationNameLength")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "ContactValidationEmailRequired")]
        [EmailAddress(ErrorMessage = "ContactValidationEmailInvalid")]
        public string Email { get; set; } = "";

        [Phone(ErrorMessage = "ContactValidationPhoneInvalid")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "ContactValidationMessageRequired")]
        [StringLength(1000, ErrorMessage = "ContactValidationMessageLength")]
        public string Message { get; set; } = "";
    }
}
