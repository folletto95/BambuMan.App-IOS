using InputKit.Shared.Validations;

namespace BambuMan.Validation
{
    public class NumericNullableValidation : IValidation
    {
        public string Message => "The field should contain only numeric values.";

        public bool Validate(object? value)
        {
            return value switch
            {
                null => true,
                "" => true,
                string text => double.TryParse(text, out _),
                _ => false
            };
        }
    }
}
