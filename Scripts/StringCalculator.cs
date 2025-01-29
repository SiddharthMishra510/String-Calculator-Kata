public class StringCalculator
{
    private readonly Tokenizer tokenizer = new();
    private readonly Parser parser = new();
    
    public int Add(string input)
    {
        List<string> tokens = tokenizer.Tokenize(input);
        List<int> numbers = parser.ParseIntegers(tokens);
        ValidityChecker validityChecker = new ValidityChecker();
        List<int> nonZeroNumbers = 
            validityChecker.ExtractValidNumbersAndThrow(numbers, new Validator(number => number >= 0));
        List<int> lessThan1000Numbers = 
            validityChecker.ExtractValidNumbers(nonZeroNumbers, new Validator(number => number <= 1000));
        return Add(lessThan1000Numbers);
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