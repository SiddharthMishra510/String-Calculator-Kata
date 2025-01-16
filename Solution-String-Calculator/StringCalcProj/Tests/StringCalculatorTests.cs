using NUnit.Framework;

namespace StringCalcProj.Tests;

public class StringCalculatorTests
{
    [Test]
    public void Add_Nothing_ShouldReturnZero()
    {
        StringCalculator stringCalculator = new();
        string result = stringCalculator.Add("");
        Assert.That(result, Is.EqualTo(0));
    }
}