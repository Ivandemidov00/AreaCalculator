using AreaCalculator.Exceptions;
using AreaCalculator.Interfaces;
using AreaCalculator.Models;

namespace AreaCalculator.Implementations;

public class AreaCalculator : IAreaCalculator
{
    private readonly IEnumerable<IShapeCalculator> _shapeCalculators;
    public AreaCalculator(IEnumerable<IShapeCalculator> shapeCalculators)
    {
        _shapeCalculators = shapeCalculators;
    }

    public double Calculate(Shape shape)
    {
        var shapeName = shape.GetType().Name;
        var calculator = _shapeCalculators.FirstOrDefault(_ => _.GetType().BaseType?.GetGenericArguments()[1].Name == shapeName);
        if (calculator == null)
        {
            throw new AreaCalculatorException($"{shapeName} area calculator not found");
        }
        return calculator.CalculateInternal(shape);
    }
}