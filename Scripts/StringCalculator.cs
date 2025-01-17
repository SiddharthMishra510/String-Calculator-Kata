public class StringCalculator
{
    private readonly Tokenizer tokenizer = new();
    private readonly Parser parser = new();

    public int Add(string input)
    {
        List<string> tokens = tokenizer.Tokenize(input);
        List<int> numbers = parser.ParseIntegers(tokens);
        return Add(numbers);
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