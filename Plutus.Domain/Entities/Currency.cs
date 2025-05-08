using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Currency : BaseEntity<int>
{
    public Currency()
    {
    }

    private Currency(
        string code,
        string description,
        double ratio)
    {
        Code = code;
        Description = description;
        Ratio = ratio;
    }

    public string Code { get; set; }
    public string Description { get; set; }
    public double Ratio { get; set; }

    #region Domain Method

    public static Currency Create(string code, string description, double ratio)
    {
        return new Currency(code, description, ratio);
    }

    #endregion
}