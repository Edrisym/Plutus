using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class AccountConfigurations : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        //TODO
        throw new NotImplementedException();
    }
}