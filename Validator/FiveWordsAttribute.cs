using System.ComponentModel.DataAnnotations;

namespace il_mio_primo_blog.Validator
{
    public class FiveWordsAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string fieldValue = (string)value;
            string[] arrSpaces = fieldValue.Split(' ');

            if (fieldValue == null || arrSpaces.Length < 5)
            {
                return new ValidationResult("Il campo deve contenere almeno 5 parole");
            }

            return ValidationResult.Success;
        }
    }
}