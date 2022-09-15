using FluentValidation;

namespace AppCore.Weight.Validation;

public class WeightCategoryValidation : AbstractValidator<WeightCategory>
{
    public WeightCategoryValidation()
    {
        RuleFor(v => v.Name).NotEmpty().MaximumLength(20);
        RuleFor(v => v.Weight).GreaterThan(0);
        
    }
}