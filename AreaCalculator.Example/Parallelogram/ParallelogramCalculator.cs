using AreaCalculator.Implementations;
using Microsoft.Extensions.Logging;

namespace AreaCalculator.Example.Parallelogram;

public class ParallelogramCalculator : ShapeCalculatorAbstract<ParallelogramValidator, Parallelogram>
{
    public ParallelogramCalculator(ILogger<Parallelogram> logger) : base(logger)
    {
    }

    protected override Func<Parallelogram, double> FormulaToCalculate { get; } =
        parameters => parameters.Base * parameters.Height;
}