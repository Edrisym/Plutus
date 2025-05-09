using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Wallet : BaseEntity<int>
{
    private readonly double _balance;

    public Wallet()
    {
    }

    private Wallet(decimal balance,
        string description,
        int currencyId)
    {
        Balance = balance;
        Description = description;
        CurrencyId = currencyId;
    }

    public decimal Balance { get; set; }
    public string Description { get; set; }
    public int CurrencyId { get; set; }

    //Navigation prop
    // public Currency Currency { get; set; }

    #region Domain Methods

    public static Wallet Create(decimal balance, string description, int currencyId)
        => new Wallet(balance, description, currencyId);

    #endregion
}