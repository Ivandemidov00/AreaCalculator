using AreaCalculator.Models;

namespace AreaCalculator.Validators;

public class CommonValidator<TParameters> : IShapeValidator<TParameters> where TParameters : Shape
{
    public Func<TParameters, bool> Rule { get; } = shapeParameters =>
    {
        var properties = shapeParameters.GetType().GetProperties();
        return properties.Select(property => (double)(property.GetValue(shapeParameters) ?? 0.0))
            .All(propertyValue => propertyValue >= 0.0);
    };
}