using AreaCalculator.Implementations;
using Microsoft.Extensions.Logging;

namespace AreaCalculator.Shapes.Rectangle;

public class RectangleCalculator : ShapeCalculatorAbstract<RectangleValidator, Rectangle>
{
    public RectangleCalculator(ILogger<Rectangle> logger) : base(logger)
    {
    }

    protected override Func<Rectangle, double> FormulaToCalculate { get; } =
        parameters => parameters.Length * parameters.Width;
}