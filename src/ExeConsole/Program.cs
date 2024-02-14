using ExeConsole;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;
using Services.Services.Interfaces;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
builder.Services.AddTransient<IApp, App>();

using IHost host = builder.Build();
var app = host.Services.GetRequiredService<IApp>();
await app.Run();