using System.ComponentModel.DataAnnotations;

namespace Client
{
    public class ValueValidationAttribute : ValidationAttribute
    {
        private bool _expectedValue;
        private string _errorMessage;

        public ValueValidationAttribute(bool expectValue, string errorMessage = "")
        {
            _expectedValue = expectValue;
            _errorMessage = errorMessage;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value.GetType() != typeof(bool))
                return new ValidationResult(GetErrorMessage());
            if((bool)value != _expectedValue)
                return new ValidationResult(GetErrorMessage());
            return ValidationResult.Success;
        }
        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }

    public class MinValueValidationAttribute : ValidationAttribute
    {
        private double _minValue;
        private string _errorMessage;

        public MinValueValidationAttribute(double minValue, string errorMessage = "")
        {
            _minValue = minValue;
            _errorMessage = errorMessage;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((double)value > _minValue)
                return ValidationResult.Success;
            return new ValidationResult(GetErrorMessage());
        }
        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }
}