using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class CurrencyConfigurations : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        //TODO
        throw new NotImplementedException();
    }
}