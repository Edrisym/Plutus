using Microsoft.EntityFrameworkCore;
using Plutus.Persistence;
using Scalar.AspNetCore;

namespace Plutus.Api;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        services.AddControllers();

        services.AddDbContext<PlutusDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("PlutusPostgres")));

        var app = builder.Build();

        app.MapScalarApiReference(opt =>
        {
            opt.Title = "Scalar Example";
            opt.Theme = ScalarTheme.Mars;
            opt.DefaultHttpClient = new(ScalarTarget.Http, ScalarClient.Http11);
        });

        app.MapControllers();
        await app.RunAsync();
    }
}