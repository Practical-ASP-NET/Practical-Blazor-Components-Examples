using Blazored.LocalStorage;
using Carter;
using Courses.Demo.Shared.Contracts;
using Courses.Demo.Shared.Pages.PurchaseOrderDashboard.Models;
using Courses.Demos.Server;
using Courses.Demos.Server.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();
builder.Services.AddSingleton<PurchaseOrderStore>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IPurchaseOrderAPI, PurchaseOrderAPI>();
builder.Services.AddScoped<IProductApi, ProductAPI>();

builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();



app.UseSwagger();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapCarter();

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();