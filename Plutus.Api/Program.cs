using Microsoft.EntityFrameworkCore;
using Plutus.Persistence;

namespace Plutus.Api;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        services.AddControllers();

        services.AddDbContext<PlutusDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("PlutusPostgres")));

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}