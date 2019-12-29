using System.ComponentModel.DataAnnotations;
using CustomFramework.BaseWebApi.Contracts.Constants;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class CustomRoleRequest
    {
        [Required(ErrorMessage = ErrorMessages.Required)]
        [Display(Name = nameof(Name))]        
        public string Name { get; set; }
    }
}