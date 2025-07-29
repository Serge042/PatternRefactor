public class SalaryAccountCalculator : IInterestCalculator
{
    public double CalculateInterest(Account account)
    {
        return account.Balance * 0.5;
    }
}
