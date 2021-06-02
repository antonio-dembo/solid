namespace OpenClosedPrinciple.OCP
{
    public class RegularSavingsAccount : IAccount
    {
        public decimal Balance { get ; set ; } = 0M ;

        public decimal CalcInterests(string accType)
        {
            decimal Interest = (Balance * 4) / 100;

            if (Balance < 1000) 
            {
                Interest -= (Balance * 2) / 100;
            }
            if (Balance < 50000) 
            {
                Interest += (Balance * 4) / 100;
            }

            return Interest;
        }
    }

    public class SalarySavingsAccount : IAccount
    {
        public decimal Balance { get ; set ; } = 0M;

        public decimal CalcInterests(string accType)
        {
            decimal Interest = (Balance * 5) / 100;
            
            return Interest;
        }
    }

    public class CorporateAccount : IAccount
    {
        public decimal Balance { get ; set ; } = 0M;

        public decimal CalcInterests(string accType)
        {
            decimal Interest = (Balance * 3) / 100;

            return Interest;
        }
    }
}