public class Parser
{
    public List<int> ParseIntegers(List<string> tokens)
    {
        List<int> validNumbers = new List<int>();
        List<int> negativeNumbers = new List<int>(); 
        
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int result)) 
            {
                if (result < 0)
                {
                    negativeNumbers.Add(result);
                }
                else
                {
                    validNumbers.Add(result);
                }
            }
        }
        
        if (negativeNumbers.Count > 0)
        {
            throw new Exception($"negative numbers not allowed {string.Join(",", negativeNumbers)}");
        }
        
        return validNumbers;
    }
}