public class Account
{
    private IInterestCalculator _calculator;
    
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public Account(string type, IInterestCalculator calculator)
    {
        Type = type;
        _calculator = calculator;
    }

    public void SetCalculator(IInterestCalculator calculator)
    {
        _calculator = calculator;
    }

    public void CalculateInterest()
    {
        Interest = _calculator.CalculateInterest(this);
    }
}
