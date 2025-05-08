using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class WalletConfigurations : IEntityTypeConfiguration<Wallet>
{
    public void Configure(EntityTypeBuilder<Wallet> builder)
    {
        //TODO
        throw new NotImplementedException();
    }
}