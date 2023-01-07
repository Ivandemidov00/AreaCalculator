using AreaCalculator.Implementations;
using Microsoft.Extensions.Logging;

namespace AreaCalculator.Shapes.Triangle;

public class TriangleCalculator : ShapeCalculatorAbstract<TriangleValidator, Triangle>
{
    protected override Func<Triangle, double> FormulaToCalculate { get; }
        = parameters => 0.5 * parameters.Base * parameters.Height;

    public TriangleCalculator(ILogger<Triangle> logger) : base(logger)
    {
    }
}