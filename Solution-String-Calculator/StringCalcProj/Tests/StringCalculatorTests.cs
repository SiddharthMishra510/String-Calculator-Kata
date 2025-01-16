using NUnit.Framework;

namespace StringCalcProj.Tests;

public class StringCalculatorTests
{
    [Test]
    public void Add_Nothing_ShouldReturnZero()
    {
        StringCalculator stringCalculator = new();
        int result = stringCalculator.Add("");
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Add_One_ShouldReturnOne()
    {
        StringCalculator stringCalculator = new();
        int result = stringCalculator.Add("1");
        Assert.That(result, Is.EqualTo(1));
    }
}