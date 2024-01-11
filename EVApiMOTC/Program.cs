using EVApiMOTC.Repositories;
using EVApiMOTC.Services;
using Serilog;
using Serilog.Events;
using System.Text.Json;

/// <summary>
/// Configures and builds the web application.
/// </summary>
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.log",
        rollingInterval: RollingInterval.Hour, // Every hour creates a new log file
        retainedFileCountLimit: 24 * 30 // Maximum of 30 days of log files retained
    )
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Inject Repository and Service
builder.Services.AddScoped<EVOperatorRepository>();
builder.Services.AddScoped<EVOperatorService>();

// Configure Serilog
builder.Host.UseSerilog((context, services, configuration) => configuration
    .ReadFrom.Services(services)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.log",
        rollingInterval: RollingInterval.Hour, // Every hour creates a new log file
        retainedFileCountLimit: 24 * 30 // Maximum of 30 days of log files retained
    )
);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

// Configure the HTTP request pipeline.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
