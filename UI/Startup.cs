using Business.Abstract;
using Business.ConCreate;
using DataAccess.Abstract;
using DataAccess.ConCreate.EFCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Globalization;
using UI.SessionManager;

namespace UI
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
            services.AddScoped<IUserCreditService, UserCreditCartManager>();
            services.AddScoped<ISessionManager, UI.SessionManager.SessionManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<IUserDal, EFUserDal>();
            services.AddScoped<IUserAddressDal, EFUserAddressDal>();
            services.AddScoped<IUserCreditDal, EFUserCreditDal>();

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix, opt => opt.ResourcesPath = "Resources").AddRazorRuntimeCompilation();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/Werenda/Login/";
                        options.AccessDeniedPath = "/Werenda/Login";
                    });

            services.AddLocalization(o =>
            {
                o.ResourcesPath = "Resources";
            });
        }

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
            app.UseAuthentication();
            app.UseAuthorization();

            IList<CultureInfo> supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("tr-TR"),
                };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Werenda}/{action=Index}/{id?}");
            });

        }
    }
}
