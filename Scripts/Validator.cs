public class Validator
{
    private readonly Func<int, bool> isValid;

    public Validator(Func<int, bool> isValid)
    {
        this.isValid = isValid;
    }

    public bool IsValid(int number)
    {
        return isValid(number);
    }
}