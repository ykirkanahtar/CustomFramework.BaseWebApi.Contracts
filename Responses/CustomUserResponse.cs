using System;

namespace CustomFramework.BaseWebApi.Contracts.Responses
{
    public class CustomUserResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
    }
}