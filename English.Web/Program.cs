using English.Web;
using English.Web.Logic;
using English.Web.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient(sp => new SpellingMapper());
builder.Services.AddTransient(sp => new PhonemizationFetcher(sp.GetService<HttpClient>()!));
builder.Services.AddTransient(sp => new JsonSerializerOptionsBuilder());
builder.Services.AddSingleton(sp => new PhonemeMappingModel());
builder.Services.AddSingleton(sp => new InputTextModel());

await builder.Build().RunAsync();