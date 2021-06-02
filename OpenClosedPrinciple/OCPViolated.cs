namespace OpenClosedPrinciple
{
    public class Account
    {
        public double Interest { get; set; }
        public double Balance { get; set; }

        public double CalcInterests(string accType)
        {
            if (accType == "Regular") // savings
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate
            {
                Interest = (Balance * 3) / 100;
            }
            
            return Interest;
        }
    }
}
