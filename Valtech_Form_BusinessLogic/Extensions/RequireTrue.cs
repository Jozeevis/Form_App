using System;
using System.ComponentModel.DataAnnotations;

namespace Valtech_Form_BusinessLogic.Extensions
{
    /// <summary>
    /// DataAttribute that will only be valid if the attribute is a boolean, and is true
    /// </summary>
    public class RequireTrue : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            if (value.GetType() != typeof(bool))
                throw new InvalidOperationException("Expected boolean type but got: " + value.GetType());
            return (bool) value;
        }
    }
}
