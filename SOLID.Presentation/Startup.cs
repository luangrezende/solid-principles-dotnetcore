using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using SOLID.Database;
using System.IO;

namespace SOLID.Presentation
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddMvc();
            _ = services.AddEntityFrameworkSqlServer();
            _ = services.AddDbContext<DbContextSolid>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app)
        {
            _ = app.UseHttpsRedirection();
            _ = app.UseCookiePolicy();

            app.UseMvc(routes => routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"));

            _ = app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                root: Path.Combine(Directory.GetCurrentDirectory(), "bower_components")),
                RequestPath = "/StaticFiles"
            });

            _ = app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                root: Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),
                RequestPath = "/RootFiles"
            });

        }
    }
}
