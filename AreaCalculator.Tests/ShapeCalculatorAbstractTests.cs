using AreaCalculator.Implementations;
using AreaCalculator.Models;
using AreaCalculator.Shapes.Circle;
using AreaCalculator.Tests.Cases;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace AreaCalculator.Tests;

public class ShapeCalculatorAbstractTests
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _shapeCalculatorAbstract = new CircleCalculator(Mock.Of<ILogger<Circle>>());
    }

    private ShapeCalculatorAbstract<CircleValidator, Circle> _shapeCalculatorAbstract = null!;

    [TestCaseSource(typeof(ShapeCalculatorAbstractTestCases), nameof(ShapeCalculatorAbstractTestCases.NonValidShapeCases))]
    public double ShouldBeNullWhenNonValidShape(Circle circle)
        => Math.Round(_shapeCalculatorAbstract.Calculate(circle),0);

    [TestCaseSource(typeof(ShapeCalculatorAbstractTestCases), nameof(ShapeCalculatorAbstractTestCases.ValidShapeCases))]
    public double ShouldBeAreaWhenValidShape(Circle circle)
        => Math.Round(_shapeCalculatorAbstract.Calculate(circle),2);
}