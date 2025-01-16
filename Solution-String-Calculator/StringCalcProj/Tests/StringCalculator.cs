namespace StringCalcProj.Tests;

public class StringCalculator
{
    public int Add(string numbers)
    {
        return int.TryParse(numbers, out int result) ? result : 0;
    }
}