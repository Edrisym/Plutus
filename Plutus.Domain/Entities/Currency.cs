using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Currency : BaseEntity<int>
{
    public Currency()
    {
    }

    private Currency(
        string title,
        string code,
        string description,
        decimal ratio)
    {
        Title = title;
        Code = code;
        Description = description;
        Ratio = ratio;
    }

    public string Code { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public decimal Ratio { get; private set; }

    #region Domain Method

    public static Currency Create(string title, string code, string description, decimal ratio)
    {
        return new Currency(title, code, description, ratio);
    }

    #endregion
}