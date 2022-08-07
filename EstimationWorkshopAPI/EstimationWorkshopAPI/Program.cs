using Csla.Configuration;
using EstimationWorkshopAPI.DAL;
using EstimationWorkshopAPI.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.Configure<AppDatabaseSetting>(builder.Configuration.GetSection("AppDatabase"));

builder.Services.AddSingleton<UserService>();

builder.Services.AddCsla();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();