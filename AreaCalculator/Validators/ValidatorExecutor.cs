using AreaCalculator.Models;

namespace AreaCalculator.Validators;

public class ValidatorExecutor<TShape> where TShape : Shape
{
    public bool Validate<TValidator>(TValidator validator, TShape parameters) where TValidator : IShapeValidator<TShape>
        => validator.Rule(parameters);
}