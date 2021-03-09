using IS413Assignment5Real.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413Assignment5Real
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
            services.AddControllersWithViews();
            // this guy makes it so your db context knows what server to connect to via the connection string
            services.AddDbContext<BookDBContext>(options =>
                options.UseSqlite(Configuration["ConnectionStrings:BooksDB"]));
            // this guyu makes it so it knows how to implement the repository we use to query from
            services.AddScoped<IBooksRepository, EFBooksRepository>();
            // add razor pages
            services.AddRazorPages();
            // allows retention of cart stuf
            services.AddDistributedMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            // lets user have stuff persist
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // category then page numeber passes
                endpoints.MapControllerRoute("IndexCategory", "P{pageNum:int}/{filterer}",
                    new { Controller = "Home", Action = "Index" });

                // just page passed
                endpoints.MapControllerRoute("page", "P{pageNum:int}",
                   new { Controller = "Home", Action = "Index" });
                // clean up stuff
                endpoints.MapControllerRoute("filterer", "{filterer}",
                 new { Controller = "Home", Action = "Index", page = 1 });
                //nfikdnskfnd
                endpoints.MapControllerRoute(
                   "pagination", "P{pageNum}",
                   new { Controller = "Home", Action = "Index" });

                endpoints.MapDefaultControllerRoute();
                // ad razor pages, also in configure services
                endpoints.MapRazorPages();

            });
            // dont forget this guy, just calls the class method that will install new migrations and populate db
            SeedData.EnsurePopulated(app);
        }
    }
}
