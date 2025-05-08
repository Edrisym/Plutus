using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Transaction : BaseEntity<Guid>
{
    public Transaction()
    {
    }

    private Transaction(double amount, int from, int to)
    {
        Amount = amount;
        From = from;
        To = to;
    }

    public double Amount { get; set; }
    public int From { get; set; }
    public int To { get; set; }

    #region Domain Methods

    public static Transaction Create(double amount, int from, int to)
    {
        return new Transaction(amount, from, to);
    }

    #endregion
}