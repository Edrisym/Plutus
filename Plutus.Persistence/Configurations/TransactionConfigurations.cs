using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class TransactionConfigurations : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        //TODO
        throw new NotImplementedException();
    }
}