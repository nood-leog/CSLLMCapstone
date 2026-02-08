using CSLLMCapstone.Components;
using CSLLMCapstone.Data;
using CSLLMCapstone.Services;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register DbContext factory
builder.Services.AddDbContextFactory<StudyContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register DbService as scoped
builder.Services.AddScoped<DbService>();
builder.Services.AddScoped<LLMService>();

// Register UserSessionService as both a service AND a CircuitHandler
builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<CircuitHandler>(sp => sp.GetRequiredService<UserSessionService>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
