using Courses.Demo.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Courses.Demos;
using Courses.Demos.Pages.Courseware;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<CustomerCoursesStore>();

var apiUrl = builder.HostEnvironment.BaseAddress;

builder.Services.AddRefitClient<IPurchaseOrderAPI>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

builder.Services.AddRefitClient<IProductApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiUrl));

await builder.Build().RunAsync();