using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plutus.Domain.Common;
using Plutus.Domain.Entities;

namespace Plutus.Persistence.Configurations;

public class CurrencyConfigurations : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.ToTable(StaticData.TableName.Currencies);

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Ratio)
            .IsRequired()
            .HasColumnType(StaticData.WalletDbContextDefaultColumnType.Decimal);

        builder.Property(x => x.Title) // Dollar,Euro,Lira
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(10) // BASEDGODS,HOTDOGE -- BTC,USD,EUR
            .IsUnicode(false);

        builder.Property(x => x.Description)
            .IsRequired(false)
            .HasMaxLength(150)
            .IsUnicode();

        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.ModifiedAt).IsRequired(false);
        builder.Property(x => x.CreatedBy).IsRequired(false);
        builder.Property(x => x.ModifiedBy).IsRequired(false);

        builder.HasIndex(c => c.Code).IsUnique();
    }
}