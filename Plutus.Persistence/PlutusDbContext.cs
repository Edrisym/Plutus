using Microsoft.EntityFrameworkCore;
using Plutus.Domain.Entities;

namespace Plutus.Persistence;

public class PlutusDbContext(DbContextOptions<PlutusDbContext> options) : DbContext(options)
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Currency> Currencies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlutusDbContext).Assembly);
    }
}