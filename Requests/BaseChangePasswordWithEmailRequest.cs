using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class BaseChangePasswordWithEmailRequest : BaseChangePasswordRequest
    {
        [Required(ErrorMessage = ErrorMessages.Required)]
        [EmailAddress(ErrorMessage = ErrorMessages.EmailAddressNotValid)]
        [Display(Name = nameof(Email))]
        public string Email { get; set; }
    }
}