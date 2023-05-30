using Ex_Gateau_Repository_Pattern.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

///summary
///Entre les accolades, vous devez sp�cifier le type que vous souhaitez enregistrer dans le conteneur d'injection de d�pendances. 
///Dans votre cas, vous pouvez enregistrer votre impl�mentation de l'interface IGateauRepository (MemGateauxRepository) en tant que
///service singleton.
builder.Services.AddSingleton<IGateauRepository, MemGateauxRepository>();
///summary
///Cela enregistrera MemGateauxRepository en tant que service singleton dans le conteneur d'injection de d�pendances. 
///Ainsi, chaque fois que IGateauRepository est demand�, une instance de MemGateauxRepository sera fournie.

//Dur�e de vie des services (instances)
//AddSingleton: Elle va cr�er une unique instance HTTP pour toute l�application � la premi�re requ�te et va r�utiliser cette instance.
//AddScroped : Une instance par requ�te sera cr��e et cette instance restera active durant toute la validit� de la requ�te. Si la requ�te est en dehors de la port�e (scope), cette instance ne sera plus valable.
//AddTransient : va cr�er une nouvelle instance � chaque fois qu�on en demande une.

//Pour cr�er un contr�leur et injecter le service IGateauRepository, vous pouvez suivre ces �tapes :
//Cr�ez un nouveau contr�leur dans votre projet ASP.NET MVC en utilisant l'ajout d'un nouvel �l�ment dans le dossier des contr�leurs.
//Par exemple, vous pouvez nommer le contr�leur GateauController.


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
