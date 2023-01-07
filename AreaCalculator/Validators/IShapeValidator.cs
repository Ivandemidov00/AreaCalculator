using AreaCalculator.Models;

namespace AreaCalculator.Validators;

public interface IShapeValidator<in TShape> where TShape : Shape
{
    public Func<TShape, bool> Rule { get; }
}