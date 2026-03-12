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
builder.Services.AddScoped<DbService>(); // required for DbService to be injected into the components
builder.Services.AddScoped<LLMService>(); // required for LLMService to be injected into the components
/*

AddScoped is used to register services that are created once per client request (or connection in the case of Blazor Server). 
This means that for each user interaction, a new instance of the service will be created and shared across all components that require it during that interaction. 
This is ideal for services that maintain state or need to be consistent throughout a user's session, such as database services or LLM services in this case. 
If you were to use AddSingleton instead, the same instance of the service would be shared across all users and all interactions, which could lead to issues with data consistency and thread safety, especially in a multi-user environment.

*/

var app = builder.Build();

// Migrate the database on startup. This ensures that the database is created and all migrations are applied before the application starts handling requests.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<StudyContext>();
        // Automatically creates the .db file and all tables from your migrations
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

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
