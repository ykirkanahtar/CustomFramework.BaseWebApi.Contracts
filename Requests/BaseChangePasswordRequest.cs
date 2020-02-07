using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;
using CustomFramework.BaseWebApi.Contracts.Utils;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class BaseChangePasswordRequest
    {

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(IdentityFieldLengths.PASSWORD_MAX, MinimumLength = IdentityFieldLengths.PASSWORD_MIN
        , ErrorMessage = ErrorMessages.StringLength)]
        [Display(Name = nameof(OldPassword))]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(IdentityFieldLengths.PASSWORD_MAX, MinimumLength = IdentityFieldLengths.PASSWORD_MIN
        , ErrorMessage = ErrorMessages.StringLength)]
        [Display(Name = nameof(NewPassword))]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = ErrorMessages.Required)]
        [StringLength(IdentityFieldLengths.PASSWORD_MAX, MinimumLength = IdentityFieldLengths.PASSWORD_MIN
        , ErrorMessage = ErrorMessages.StringLength)]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Compare(nameof(NewPassword), ErrorMessage = ErrorMessages.Compare)]
        public string ConfirmNewPassword { get; set; }
    }
}