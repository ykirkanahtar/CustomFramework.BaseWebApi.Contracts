using System.Collections.Generic;

namespace CustomFramework.BaseWebApi.Contracts.Requests
{
    public class UserAddToRolesRequest
    {
        public int UserId { get; set; }
        public List<string> Roles { get; set; }
    }
}