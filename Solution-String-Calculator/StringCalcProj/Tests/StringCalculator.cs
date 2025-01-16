namespace StringCalcProj.Tests;

public class StringCalculator
{
    public int Add(string input)
    {
        List<string> tokens = Tokenize(input);
        List<int> numbers = ParseIntoIntegers(tokens);
        return Add(numbers);
    }

    private static List<string> Tokenize(string input)
    {
        string delimiter = ",";
        string[] tokens = input.Split(delimiter);
        return tokens.ToList();
    }
    
    private static List<int> ParseIntoIntegers(List<string> tokens)
    {
        List<int> numbers = new List<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int result))
            {
                numbers.Add(result);
            }
        }

        return numbers;
    }

    private int Add(List<int> numbers)
    {
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}