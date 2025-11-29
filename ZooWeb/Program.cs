using Microsoft.EntityFrameworkCore;
using ZooWeb.Components;
using ZooWeb.Data;
using ZooWeb.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<ZooDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZooConnection")));

builder.Services.AddScoped<NastambaService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
