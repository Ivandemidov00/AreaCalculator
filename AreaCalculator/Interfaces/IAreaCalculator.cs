using AreaCalculator.Models;

namespace AreaCalculator.Interfaces;

public interface IAreaCalculator
{
    double Calculate(Shape shape);
}