using Web_.NET_AT_Exerc11.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ClienteContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ClienteContext")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/", () => Results.Redirect("/Clientes"));

app.Run();


