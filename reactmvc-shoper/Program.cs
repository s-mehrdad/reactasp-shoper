// ===========================================================================
/// <summary>
/// Program.cs
/// reactmvc-shoper
/// created by Mehrdad Soleimanimajd on 08.08.2023
/// </summary>
/// <created>ʆϒʅ, 08.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Http;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using React.AspNet;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName).AddV8();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");
    //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();

//app.UseReact(config =>
//{
//    // https://reactjs.net

//    // server side rendering
//    // .AddScript("/js/First.jsx");
//    // .AddScript("/js/Second.jsx");

//    // external build
//    // .SetLoadBabel(false);
//    // .AddScriptWithoutTransform("~/js/bundle.server.js");
//});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
