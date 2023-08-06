// ===========================================================================
/// <summary>
/// Program.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using webapi_shoper.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<shoperSQLiteContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("shoperSQLiteContext") ?? throw new InvalidOperationException("Connection string 'shoperSQLiteContext' not found.")));
builder.Services.AddDbContext<shoperSQLEContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("shoperSQLEContext") ?? throw new InvalidOperationException("Connection string 'shoperSQLEContext' not found.")));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseExceptionHandler("/Error");
    app.UseHsts();
} else
{
    app.UseDeveloperExceptionPage();
    //app.UseMigrationEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<shoperSQLEContext>();
    context.Database.EnsureCreated();
    var contextSQLite = services.GetRequiredService<shoperSQLiteContext>();
    contextSQLite.SaveChangesAsync();
    DbInitializer.Initialize(context);
    DbInitializer.Initialize(contextSQLite);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseRazorPages();

app.MapRazorPages();
//app.MapControllers();

app.Run();
