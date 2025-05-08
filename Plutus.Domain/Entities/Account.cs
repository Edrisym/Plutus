using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Common;

namespace Plutus.Domain.Entities;

public class Account : BaseEntity<int>
{
    protected Account()
    {
    }

    private Account(string ownerName)
    {
        OwnerName = ownerName;
    }

    public string OwnerName { get; private set; }
    
    //TODO: has multiple wallets


    #region Domain Method

    public static Account Create(string ownerName)
    {
        return new Account(ownerName);
    }

    #endregion
}