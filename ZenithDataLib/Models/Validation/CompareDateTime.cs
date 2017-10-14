using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models.Validation
{
    public class CompareDateTime : ValidationAttribute
    {
        private readonly string _eventFromDatePropertyName;
        public CompareDateTime(string eventFromDatePropertyName)
        {
            if (string.IsNullOrEmpty(eventFromDatePropertyName))
                throw new ArgumentNullException("eventFromDatePropertyName");
            _eventFromDatePropertyName = eventFromDatePropertyName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo eventFromDatePropertyInfo = validationContext.ObjectType.GetProperty(_eventFromDatePropertyName);
            if (eventFromDatePropertyInfo == null)
            {
                return new ValidationResult("Could not find a property named }" + _eventFromDatePropertyName);
            }
            DateTime eventFromDate = (DateTime)eventFromDatePropertyInfo.GetValue(validationContext.ObjectInstance);
            DateTime dt = (DateTime)value;
            if (dt > eventFromDate)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "Date and time must be later than event start date and time");
        }
    }
}
