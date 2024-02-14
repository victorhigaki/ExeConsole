using ExeConsole;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
