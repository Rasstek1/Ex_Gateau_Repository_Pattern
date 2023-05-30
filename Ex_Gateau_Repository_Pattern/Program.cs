using Ex_Gateau_Repository_Pattern.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

///summary
///Entre les accolades, vous devez spécifier le type que vous souhaitez enregistrer dans le conteneur d'injection de dépendances. 
///Dans votre cas, vous pouvez enregistrer votre implémentation de l'interface IGateauRepository (MemGateauxRepository) en tant que
///service singleton.
builder.Services.AddSingleton<IGateauRepository, MemGateauxRepository>();
///summary
///Cela enregistrera MemGateauxRepository en tant que service singleton dans le conteneur d'injection de dépendances. 
///Ainsi, chaque fois que IGateauRepository est demandé, une instance de MemGateauxRepository sera fournie.

//Durée de vie des services (instances)
//AddSingleton: Elle va créer une unique instance HTTP pour toute l’application à la première requête et va réutiliser cette instance.
//AddScroped : Une instance par requête sera créée et cette instance restera active durant toute la validité de la requête. Si la requête est en dehors de la portée (scope), cette instance ne sera plus valable.
//AddTransient : va créer une nouvelle instance à chaque fois qu’on en demande une.

//Pour créer un contrôleur et injecter le service IGateauRepository, vous pouvez suivre ces étapes :
//Créez un nouveau contrôleur dans votre projet ASP.NET MVC en utilisant l'ajout d'un nouvel élément dans le dossier des contrôleurs.
//Par exemple, vous pouvez nommer le contrôleur GateauController.


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "ingredients",
        pattern: "gateau/ingredients/{id}",
        defaults: new { controller = "Gateau", action = "Ingredients" });
});



app.Run();
