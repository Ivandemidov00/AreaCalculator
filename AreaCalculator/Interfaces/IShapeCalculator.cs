using AreaCalculator.Models;

namespace AreaCalculator.Interfaces;

public interface IShapeCalculator<in TShape> where TShape : Shape
{
    public double Calculate(TShape shape);
}

public interface IShapeCalculator
{
    internal double CalculateInternal(Shape shape);
}