namespace OpenClosedPrinciple.OCP
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        decimal CalcInterests (string accType);
    }
}