using System.Collections;
using AreaCalculator.Shapes.Circle;
using AreaCalculator.Shapes.Triangle;
using NUnit.Framework;

namespace AreaCalculator.Tests.Cases;

public class AreaCalculatorTestCases
{
    public static IEnumerable CalculatorExistCases
    {
        get
        {
            yield return new TestCaseData(new Circle(1)).Returns(3.14);
        }
    }
    
    public static IEnumerable CalculatorNonExistCases
    {
        get
        {
            yield return new TestCaseData(new Triangle(1, 8));
        }
    }
}