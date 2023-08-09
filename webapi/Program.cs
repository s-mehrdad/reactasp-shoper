// ===========================================================================
/// <summary>
/// Program.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 09.08.2023</changed>
// ===========================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using webapi_shoper.Data;
using webapi_shoper.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<shoperSQLEContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("shoperSQLEContext") ??
    throw new InvalidOperationException("Connection string 'shoperSQLEContext' not found."))
    );

builder.Services.AddDbContext<shoperSQLiteContext>(
    options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("shoperSQLiteContext") ??
    throw new InvalidOperationException("Connection string 'shoperSQLiteContext' not found."))
    );

var sqlite = new DbConnections(builder.Configuration.GetConnectionString("shoperSQLiteContextSQL"));



// configure services.
// builder.Services.Configure<CookiePolicyOptions>(options =>
// {
//     options.CheckConsentNeeded = context => true;
// });

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


//builder.Services.AddDatabaseDeveloperPageExceptionFilter();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "shoper API",
        Description = "shop app",
        //TermsOfService = new Uri(""),
        //...
    });

    //using System.Reflection;
    //var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//builder.Services.AddOpenApiDocument();



var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        //options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        //options.RoutePrefix = string.Empty;
    });
    //app.UseOpenApi();
    //app.UseSwaggerUi3();

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
    DbInitializer.Initialize(context);

    var contextSQLite = services.GetRequiredService<shoperSQLiteContext>();
    contextSQLite.Database.EnsureCreated();
    DbInitializer.Initialize(contextSQLite);

    //var contextT = services.GetRequiredService<TodoContext>();
    //contextT.TodoItems.Add(new TodoItem { Name = "first" });
    //await contextT.SaveChangesAsync();


}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();
//app.UseRazorPages();


// middle-wares
app.MapRazorPages();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
