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

        public void Configure(IApplicationBuilder app)
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
        }
    }
}
    