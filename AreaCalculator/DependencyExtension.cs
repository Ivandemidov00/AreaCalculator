using AreaCalculator.Interfaces;
using AreaCalculator.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AreaCalculator;

public static class DependencyExtension
{
    public static IServiceCollection AddShape<TShape, TCalculator>(this IServiceCollection serviceCollection)
        where TShape : Shape
        where TCalculator : class, IShapeCalculator
    {
        serviceCollection.AddSingleton<IShapeCalculator, TCalculator>();
        serviceCollection.TryAddSingleton(typeof(IAreaCalculator), typeof(Implementations.AreaCalculator));
        return serviceCollection;
    }
}