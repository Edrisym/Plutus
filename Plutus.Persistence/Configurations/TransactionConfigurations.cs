using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plutus.Domain.Common;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class TransactionConfigurations : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable(StaticData.TableName.Transactions);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType(StaticData.WalletDbContextDefaultColumnType.Nvarchar36);

        builder.Property(x => x.From)
            .HasMaxLength(36)
            .IsRequired();

        builder.Property(x => x.To)
            .HasMaxLength(36)
            .IsRequired();

        builder.Property(x => x.Amount)
            .HasColumnType(StaticData.WalletDbContextDefaultColumnType.Decimal)
            .IsRequired();

        builder.Property(p => p.State)
            .HasConversion(new EnumToStringConverter<TransactionState>())
            .HasColumnName("TransactionState")
            .HasMaxLength(64)
            .IsRequired();
    }
}