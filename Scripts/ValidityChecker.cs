public class ValidityChecker
{
    public List<int> ExtractValidNumbers(List<int> numbers, Validator validator)
    {
        List<int> validNumbers = new();
        
        foreach (int number in numbers)
        {
            if (validator.IsValid(number))
            {
                validNumbers.Add(number);
            }
        }
        
        return validNumbers;
    }
    
    public List<int> ExtractValidNumbersAndThrow(List<int> numbers, Validator validator)
    {
        List<int> validNumbers = new();
        List<int> invalidNumbers = new();
        
        foreach (int number in numbers)
        {
            if (validator.IsValid(number))
            {
                validNumbers.Add(number);
            }
            else
            {
                invalidNumbers.Add(number);
            }
        }
        
        if (invalidNumbers.Count > 0)
        {
            throw new Exception($"negative numbers not allowed {string.Join(",", invalidNumbers)}");
        }
        
        return validNumbers;
    }
}