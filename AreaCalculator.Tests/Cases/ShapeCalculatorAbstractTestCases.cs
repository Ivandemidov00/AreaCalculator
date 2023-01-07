using System.Collections;
using AreaCalculator.Shapes.Circle;
using NUnit.Framework;

namespace AreaCalculator.Tests.Cases;

public class ShapeCalculatorAbstractTestCases
{
    public static IEnumerable NonValidShapeCases
    {
        get
        {
            yield return new TestCaseData(new Circle(-1)).Returns(0.00);
        }
    }
    
    public static IEnumerable ValidShapeCases
    {
        get
        {
            yield return new TestCaseData(new Circle(1)).Returns(3.14);
        }
    }
}