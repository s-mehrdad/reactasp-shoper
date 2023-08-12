// ===========================================================================
/// <summary>
/// Program.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using razorasp_shoper.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<shoperContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("shoperContext") ??
        throw new InvalidOperationException("Connection string 'shoperContext' not found."))
    );

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} else
{
    app.UseDeveloperExceptionPage();
    //app.UseMigrationEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<shoperContext>();

    // early development stages (recreate)
    context.Database.EnsureCreated();
    shoperContext.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
