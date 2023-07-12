using Ex_Gateau_Repository_Pattern.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GateauDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:GateauDbContextConnection"]);
});

builder.Services.AddScoped<IGateauRepository, BDGateauRepository>();
builder.Services.AddScoped<IIngredientsRepository, BDIngredientRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "ingredients",
    pattern: "gateau/ingredients/{id}",
    defaults: new { controller = "Gateau", action = "Ingredients" });

app.MapControllerRoute(
    name: "create",
    pattern: "gateau/create",
    defaults: new { controller = "Gateau", action = "Create" });

app.MapControllerRoute(
    name: "ModifierIngredients",
    pattern: "Gateau/ModifierIngredients/{id}",
    defaults: new { controller = "Gateau", action = "ModifierIngredients" });

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var dbContext = serviceProvider.GetRequiredService<GateauDbContext>();
    dbContext.Database.EnsureCreated();

    if (!dbContext.Gateaux.Any())
    {
        dbContext.Gateaux.AddRange(InitialiseurBD.NomGateauDict.Values);
        dbContext.SaveChanges();
    }

    if (!dbContext.Ingredients.Any())
    {
        dbContext.Ingredients.AddRange(InitialiseurBD._ingredients);
        dbContext.SaveChanges();
    }
}

app.Run();
