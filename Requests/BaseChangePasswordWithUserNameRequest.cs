using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class BaseChangePasswordWithUserNameRequest : BaseChangePasswordRequest
    {
        [Required(ErrorMessage = ErrorMessages.Required)]      
        [Display(Name = nameof(UserName))]
        public string UserName { get; set; }
    }
}