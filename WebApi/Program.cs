using Core.Utility;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

AppConfig.AddAppSettings(builder.Configuration);

AppConfig.LoadEnv();

builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.File("/var/logs/devlab-api/logs.txt", rollingInterval: RollingInterval.Day)
    .MinimumLevel.Information());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health");

app.UseSerilogRequestLogging();

app.Run();

public partial class Program {}