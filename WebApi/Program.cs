using System.Net.Mime;
using System.Text.Json.Serialization;
using Core.RepositoryInterfaces;
using Core.Services;
using Core.Utility;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Diagnostics;
using Serilog;
using Serilog.Core;

var _origins = "_origins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: _origins,
        policy  =>
        {
            policy.WithOrigins("http://localhost:3000","https://*.fullstackdan.com")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

AppConfig.AddAppSettings(builder.Configuration);

AppConfig.LoadEnv();

builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Configuration(context.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.File("/var/log/devlab-api/logs.txt", rollingInterval: RollingInterval.Day)
    .MinimumLevel.Information());


builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IQuestionService, QuestionService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(_origins);

app.UseExceptionHandler(exceptionHandlerApp =>
{
    exceptionHandlerApp.Run(async context =>
    {
        context.Response.ContentType = MediaTypeNames.Text.Plain;

        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
        var error = exceptionHandlerPathFeature?.Error;

        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext()
            .WriteTo.File("/var/log/devlab-api/logs.txt", rollingInterval: RollingInterval.Day)
            .MinimumLevel.Information()
            .CreateLogger();
            
            logger.Error(error,
            "Exception thrown at {0}, Message: {1}",
            context.Request.Path + context.Request.QueryString, 
            error.Message);

        if (exceptionHandlerPathFeature?.Error is BusinessException)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsync(error.Message);
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsync("An error occurred. Please try again.");
        }
    });
});

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health");

app.UseSerilogRequestLogging();

app.Run();

public partial class Program {}