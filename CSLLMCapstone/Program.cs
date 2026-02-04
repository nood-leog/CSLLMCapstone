using CSLLMCapstone.Components;
using CSLLMCapstone.Data;
using CSLLMCapstone.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Server.Circuits; // <-- Add this using directive

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register DbContext factory
builder.Services.AddDbContextFactory<StudyContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register DbService as scoped
builder.Services.AddScoped<DbService>();

// Register UserSessionService as a Circuit Handler (keeps state per user connection)
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
