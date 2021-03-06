using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class ConfirmEmailRequest
    {
        [Required(ErrorMessage = ErrorMessages.Required)]
        [Display(Name = "User")]
        public int UserId { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [Display(Name = nameof(Code))]
        public string Code { get; set; }
    }
}