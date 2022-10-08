using System.ComponentModel.DataAnnotations;

namespace Homo.Api
{
    public class Required : RequiredAttribute
    {
        public Required() : base()
        {
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.GetType().IsEnum)
            {
                return ValidationResult.Success;
            }

            string stringify = (string)value;
            if (System.String.IsNullOrEmpty(stringify))
            {
                ValidationLocalizer validationLocalizer = validationContext.GetService(typeof(ValidationLocalizer)) as ValidationLocalizer;
                return new ValidationResult(validationLocalizer.Get($"{validationContext.MemberName} is required"));
            }
            return ValidationResult.Success;
        }
    }
}