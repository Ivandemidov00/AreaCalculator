using AreaCalculator.Validators;

namespace AreaCalculator.Shapes.Triangle;

public class TriangleValidator : IShapeValidator<Triangle>
{
    public Func<Triangle, bool> Rule { get; } = parameters => parameters.Height > 2;
}