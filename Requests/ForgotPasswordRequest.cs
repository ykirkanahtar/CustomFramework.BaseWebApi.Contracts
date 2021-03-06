using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class ForgotPasswordRequest
    {
        [Required(ErrorMessage = ErrorMessages.Required)]
        [EmailAddress(ErrorMessage = ErrorMessages.EmailAddressNotValid)]
        [Display(Name = nameof(EmailAddress))]

        public string EmailAddress { get; set; }

        public string CallBackUrl { get; set; }

    }
}