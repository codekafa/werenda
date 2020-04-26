using Business.Abstract;
using Business.ConCreate;
using DataAccess.Abstract;
using DataAccess.ConCreate.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Panel.SessionManager;

namespace Panel
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSession();
            services.AddDistributedMemoryCache();

            services.AddScoped<IUIService, UIManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ISessionManager, Panel.SessionManager.SessionManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<IUserDal, EFUserDal>();
            services.AddScoped<IUserAddressDal, EFUserAddressDal>();

           

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Panel}/{action=Dashboard}/{id?}");
            });
        }
    }
}
