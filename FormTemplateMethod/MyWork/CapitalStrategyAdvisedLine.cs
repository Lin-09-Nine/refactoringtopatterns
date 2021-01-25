namespace FormTemplateMethod.MyWork
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double RiskAmountFor(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage();
        }
    }
}