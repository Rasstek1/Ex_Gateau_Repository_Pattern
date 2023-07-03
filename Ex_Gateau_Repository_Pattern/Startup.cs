using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ex_Gateau_Repository_Pattern.Models;

namespace Ex_Gateau_Repository_Pattern
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Ajoutez votre implémentation de l'interface IGateauRepository en tant que service singleton
            services.AddSingleton<IGateauRepository, MemGateauxRepository>();
        }

        public void Configure(IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "gateau",
                    pattern: "{controller=Gateau}/{action=Index}/{id?}");
            });

            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<GateauDbContext>();
                dbContext.Database.EnsureCreated(); // Crée la base de données si elle n'existe pas

                if (!dbContext.Gateaux.Any()) // Vérifie si la table Gateaux est vide
                {
                    // Ajoute les données de gâteaux à la base de données
                    dbContext.Gateaux.AddRange(
                        new Gateau
                        {
                            // Propriétés du premier gâteau
                        },
                        new Gateau
                        {
                            // Propriétés du deuxième gâteau
                        }
                        // Ajouter les autres gâteaux...
                    );

                    dbContext.SaveChanges(); // Sauvegarde les changements dans la base de données
                }
            }
        }
    }
}
    