using Blazored.LocalStorage;
using Courses.Demo.Shared.Contracts;
using Courses.Demo.Shared.Pages.ComponentDesign.ShoppingCart;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
// builder.RootComponents.Add<App>("#app");
// builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<ICartService, HardcodedCartService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var apiUrl = builder.HostEnvironment.BaseAddress;

builder.Services.AddRefitClient<IPurchaseOrderAPI>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

builder.Services.AddRefitClient<IProductApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

await builder.Build().RunAsync();