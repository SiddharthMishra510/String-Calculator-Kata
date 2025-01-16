namespace StringCalcProj.Tests;

public class StringCalculator
{
    public int Add(string numbers)
    {
        var listOfNumbers = numbers.Split(",").ToList();
        int sum = 0;
        foreach (var number in listOfNumbers)
        {
            if (int.TryParse(number, out var result))
            {
                sum += result;
            }
        }

        return sum;
    }
}