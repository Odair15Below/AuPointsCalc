using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AuPointsCalc;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddScoped<ICategoryLoader, CategoryLoaderFromConfig>();
var appData = builder.Configuration.GetSection("AppData").Get<AppData>();
builder.Services.AddScoped(s => appData);
builder.Services.AddScoped<PointsCalculator>();

await builder.Build().RunAsync();
