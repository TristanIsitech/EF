using System;
using System.ComponentModel.DataAnnotations;
using MyWebApi.Utils.ErrorMessage;

namespace MyWebApi.Utils.Validation;

public class CompareDatesAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public CompareDatesAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not DateTime currentValue)
            return new ValidationResult(ErrorMessage.PropertyNotFound);

        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
        if (property == null)
            return new ValidationResult(string.Format(MyWebApi.Utils.ErrorMessage.PropertyNotFound, _comparisonProperty));

        var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance)!;

        if (currentValue <= comparisonValue)
            return new ValidationResult(MyWebApi.Utils.ErrorMessage.EndDateBeforeStartDate);

        return ValidationResult.Success;
    }
}
