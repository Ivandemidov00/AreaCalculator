using AreaCalculator.Validators;

namespace AreaCalculator.Shapes.Rectangle;

public class RectangleValidator : IShapeValidator<Rectangle>
{
    public Func<Rectangle, bool> Rule { get; } = _ => true;
}