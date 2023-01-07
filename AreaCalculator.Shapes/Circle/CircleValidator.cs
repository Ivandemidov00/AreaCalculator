using AreaCalculator.Validators;

namespace AreaCalculator.Shapes.Circle;

public class CircleValidator : IShapeValidator<Circle>
{
    public Func<Circle, bool> Rule { get; } = parameters => parameters.Radius > 0.0;
}