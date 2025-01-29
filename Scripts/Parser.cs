public class Parser
{
    public List<int> ParseIntegers(List<string> tokens)
    {
        List<int> validNumbers = new List<int>();
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int result)) 
            {
                validNumbers.Add(result);
            }
        }
        return validNumbers;
    }
}