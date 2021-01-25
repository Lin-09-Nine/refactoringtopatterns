namespace FormTemplateMethod.MyWork
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return RiskAmountFor(loan) * Duration(loan) * RiskFactorFor(loan);
        }

        private static double RiskAmountFor(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage();
        }
    }
}