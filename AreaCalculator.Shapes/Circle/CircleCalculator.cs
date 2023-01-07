using AreaCalculator.Implementations;
using Microsoft.Extensions.Logging;

namespace AreaCalculator.Shapes.Circle;

public class CircleCalculator : ShapeCalculatorAbstract<CircleValidator, Circle>
{
    protected override Func<Circle, double> FormulaToCalculate { get; } =
        parameters => Math.Pow(parameters.Radius, 2) * Math.PI;

    public CircleCalculator(ILogger<Circle> logger) : base(logger)
    {
    }
}
