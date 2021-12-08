using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Photovoir.Data;
using Photovoir.Data.DataAccessObjects;
using Photovoir.Data.User;
using Photovoir.Interfaces;
using Photovoir.Services;
using Photovoir.Services.Persistence.Helper;
using Photovoir.Services.Persistence.Repositories.Orders;
using Photovoir.Services.Persistence.Repositories.Products;
using Photovoir.Services.Stores;

namespace Photovoir
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // User + role Stores
            services.AddTransient<IUserStore<ApplicationUser>, UserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, RoleStore>();

            // Data Access Objects
            services.AddTransient<IProductDao, ProductDao>();
            services.AddTransient<IOrderDao, OrderDao>();

            // Repositories
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            // Helpers
            services.AddTransient<ISqlHelper, SqlHelper>();
            services.AddTransient<ITransaction, Transaction>();

            // Identity
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddDefaultTokenProviders();

            // Services
            services.AddTransient<IEmailSender, EmailSender>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
