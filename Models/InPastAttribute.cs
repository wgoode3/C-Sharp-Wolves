using System;
using System.ComponentModel.DataAnnotations;

namespace Wolves.Models
{
    public class InPastAttribute : ValidationAttribute{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            if(value != null && (DateTime)value > DateTime.Now){
                return new ValidationResult("Date must be in the past!");
            }
            return ValidationResult.Success;
        }
    }
}