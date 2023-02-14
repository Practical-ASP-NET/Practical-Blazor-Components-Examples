using Courses.Demo.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Courses.Demos;
using Courses.Demos.Pages.PurchaseOrderDashboard.Models;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRefitClient<IPurchaseOrderAPI>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5102/"));

builder.Services.AddRefitClient<IProductApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5102/"));

await builder.Build().RunAsync();