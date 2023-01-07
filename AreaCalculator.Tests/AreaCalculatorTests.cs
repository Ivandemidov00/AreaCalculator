using AreaCalculator.Exceptions;
using AreaCalculator.Interfaces;
using AreaCalculator.Shapes.Circle;
using AreaCalculator.Shapes.Triangle;
using AreaCalculator.Tests.Cases;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using AreaCalculatorImplementations = AreaCalculator.Implementations.AreaCalculator;

namespace AreaCalculator.Tests;

public class AreaCalculatorTests
{
    [OneTimeSetUp]
    public void OneTimSetUp()
    {
        var shapeCalculators = new IShapeCalculator[]{ new CircleCalculator(Mock.Of<ILogger<Circle>>()) };
        _areaCalculator = new AreaCalculatorImplementations(shapeCalculators);
    }

    private IAreaCalculator _areaCalculator;

    [TestCaseSource(typeof(AreaCalculatorTestCases), nameof(AreaCalculatorTestCases.CalculatorExistCases))]
    public double ShouldBeAreaIfShapeCalculatorExist(Circle circle)
        => Math.Round(_areaCalculator.Calculate(circle), 2);
    
    [TestCaseSource(typeof(AreaCalculatorTestCases), nameof(AreaCalculatorTestCases.CalculatorNonExistCases))]
    public void ShouldBeExceptionIfShapeCalculatorNonExist(Triangle triangle)
        => Assert.Throws<AreaCalculatorException>(() =>_areaCalculator.Calculate(triangle));
}