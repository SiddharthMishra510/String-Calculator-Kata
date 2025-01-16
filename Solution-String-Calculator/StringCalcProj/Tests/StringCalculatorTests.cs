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

    [Test]
    public void Add_TwoNumbers_ShouldReturnSum()
    {
        StringCalculator stringCalculator = new();
        int result = stringCalculator.Add("1,5");
        Assert.That(result, Is.EqualTo(6));
    }
    
    [Test]
    public void Add_ThreeNumbers_ShouldReturnSum()
    {
        StringCalculator stringCalculator = new();
        int result = stringCalculator.Add("1,5,7");
        Assert.That(result, Is.EqualTo(13));
    }
    
    [Test]
    public void Add_TenNumbers_ShouldReturnSum()
    {
        StringCalculator stringCalculator = new();
        int result = stringCalculator.Add("1,5,7,91,0,4,5,67,44,9000");
        Assert.That(result, Is.EqualTo(9224));
    }
}