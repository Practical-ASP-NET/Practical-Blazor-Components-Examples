using Courses.Demo.Shared;
using Courses.Demo.Shared.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;
using Courses.Demos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var apiUrl = builder.HostEnvironment.BaseAddress;

builder.Services.AddRefitClient<IPurchaseOrderAPI>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

builder.Services.AddRefitClient<IProductApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

await builder.Build().RunAsync();