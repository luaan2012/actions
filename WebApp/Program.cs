using WebApp;
using WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddRedisOutputCache("rediscache");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<WetherApiClient>(x =>
{
    x.BaseAddress = new Uri("http://webapi");
});

var app = builder.Build();

app.MapDefaultEndpoints();

app.UseOutputCache();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
