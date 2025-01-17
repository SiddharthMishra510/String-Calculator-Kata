public class Tokenizer
{
    private const string TokenizerSpecifyingSequence = "//";
    private readonly char[] defaultDelimiters = { ',', '\n' };
    
    public List<string> Tokenize(string input)
    {
        if (IsDelimiterSpecified(input))
        {
            char delimiter = GetDelimiter(input);
            input = SkipDelimiterSpecification(input);
            return SplitInput(input, delimiter);
        }
        return SplitInput(input);
    }
    
    private bool IsDelimiterSpecified(string input)
    {
        return input.StartsWith(TokenizerSpecifyingSequence);
    }

    private char GetDelimiter(string input)
    {
        return input[TokenizerSpecifyingSequence.Length];
    }
    
    private string SkipDelimiterSpecification(string input)
    {
        return input[(TokenizerSpecifyingSequence.Length + 2)..];
    }
    
    private List<string> SplitInput(string input, char delimiter)
    {
        return input.Split(delimiter).ToList();
    }

    private List<string> SplitInput(string input)
    {
        return input.Split(defaultDelimiters).ToList();
    }
}