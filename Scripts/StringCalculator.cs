public class StringCalculator
{
    private readonly Tokenizer tokenizer = new();
    private readonly Parser parser = new();

    public int Add(string input)
    {
        List<string> tokens = tokenizer.Tokenize(input);
        List<int> numbers = parser.ParseIntegers(tokens);

        List<int> validNumbers = new();
        foreach (int number in numbers)
        {
            if (number <= 1000)
            {
                validNumbers.Add(number);
            }
        }
        return Add(validNumbers);
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