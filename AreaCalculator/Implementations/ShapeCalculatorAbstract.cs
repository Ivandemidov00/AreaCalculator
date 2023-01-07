using AreaCalculator.Interfaces;
using AreaCalculator.Models;
using AreaCalculator.Validators;
using Microsoft.Extensions.Logging;

namespace AreaCalculator.Implementations;

public abstract class ShapeCalculatorAbstract<TValidator, TShape> : IShapeCalculator, IShapeCalculator<TShape> where TValidator : IShapeValidator<TShape>, new()
    where TShape : Shape
{
    private readonly TValidator _customValidator;
    private readonly CommonValidator<TShape> _commonValidator;
    private readonly ValidatorExecutor<TShape> _validatorExecutor;
    private readonly ILogger<TShape> _logger;

    protected ShapeCalculatorAbstract(ILogger<TShape> logger)
    {
        _logger = logger;
        _validatorExecutor = new ValidatorExecutor<TShape>();
        _commonValidator = new CommonValidator<TShape>();
        _customValidator = new TValidator();
    }
    protected abstract Func<TShape, double> FormulaToCalculate { get; }

    public virtual double Calculate(TShape shape)
    {
        if (_validatorExecutor.Validate(_commonValidator, shape) && _validatorExecutor.Validate(_customValidator, shape))
        {
            return FormulaToCalculate(shape);
        }
        _logger.LogError("Validate error, shape: {ShapeParams}", shape.ToString());
        return default;
    }
    

    double IShapeCalculator.CalculateInternal(Shape shape)
    {
        return Calculate((TShape)shape);
    }
}