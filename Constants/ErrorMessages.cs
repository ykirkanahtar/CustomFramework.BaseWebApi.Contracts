namespace CustomFramework.BaseWebApi.Contracts.Constants
{
    public static class ErrorMessages
    {
        public const string Required = "The {0} field is required.";
        public const string StringLength = "The field {0} must be a string with a minimum length of {2} and a maximum length of {1}.";
        public const string StringLengthFixed = "The field {0} must be a string with length of {1}.";
        public const string RangeWithMinValue = "The field {0} must be greater than or equal to {1}.";
        public const string RangeError = "The field {0} must be between {1} and {2}.";
        public const string EmailAddressNotValid = "The {0} field is not a valid e-mail address.";
        public const string Compare = "{0} and {1} do not match.";
        public const string InvalidDateOfBirth = "Invalid date of birth";
        public const string InvalidDate = "Invalid date";
        public const string MustBeANumber = "'{0}' must be a number";
        public const string DecimalPlacesError = "{0} field can not be have more than 2 places";

    }

}