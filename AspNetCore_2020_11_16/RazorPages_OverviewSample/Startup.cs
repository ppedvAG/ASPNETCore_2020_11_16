using GoodDependencyLib.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPages_OverviewSample.Pages.Modul003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService;
using Westwind.AspNetCore.LiveReload;

namespace RazorPages_OverviewSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddLiveReload(config =>
            {
                //// optional - use config instead
                //config.LiveReloadEnabled = true;
                //config.FolderToMonitor = Path.GetFullname(Path.Combine(Env.ContentRootPath,"..")) ;
            });

            // for ASP.NET Core 3.x and later, add Runtime Razor Compilation if using anything Razor

            services.AddRazorPages()
                .AddRazorRuntimeCompilation()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/Modul005/Blogs/Overview", "Blogs");
                    options.Conventions.AddPageRoute("/Modul005/Blogs/Archive/Blogs", "Search/{year}/{month}/{day}");
                    options.Conventions.AddPageRoute("/index", "/Modul001/{*url}");
                         //options.RootDirectory = "/Content"; -> PAge-Verzeichnis wäre hier das Content-Verzeichnis
                     });


            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddSingleton(typeof(ICarService), typeof(CarService)); //Einmal wird initialisiert und lebt solange die Webseite aktiv läuft.
            services.AddScoped(typeof(ICar), typeof(TestCarObj2)); // Bei Scope wird pro Request das TestCarObj2 neu instanziiert. 

            services.AddScoped(typeof(IUserService), typeof(MyUserService));
            //services.AddTransient(typeof(ICar), typeof(TestCarObj2));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseLiveReload();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            
            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();


            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbnailGen();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
