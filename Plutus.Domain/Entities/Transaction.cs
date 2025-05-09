using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Transaction : BaseEntity<Guid>
{
    public Transaction()
    {
    }

    private Transaction(decimal amount, int from, int to, TransactionState state)
    {
        Amount = amount;
        From = from;
        To = to;
        State = state;
    }

    public decimal Amount { get; private set; }
    public int From { get; private set; }
    public int To { get; private set; }
    public TransactionState State { get; private set; }

    #region Domain Methods

    public static Transaction Create(decimal amount, int from, int to, TransactionState state)
    {
        return new Transaction(amount, from, to, state);
    }

    #endregion
}