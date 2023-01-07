using AreaCalculator.Validators;

namespace AreaCalculator.Example.Parallelogram;

public class ParallelogramValidator : IShapeValidator<Parallelogram>
{
    public Func<Parallelogram, bool> Rule { get; } = _ => true;
}