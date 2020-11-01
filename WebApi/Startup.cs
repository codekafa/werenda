using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ConCreate;
using DataAccess.Abstract;
using DataAccess.ConCreate.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApi
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
       

            services.AddScoped<IUIService, UIManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserCreditService, UserCreditCartManager>();
            services.AddScoped<IDefinitionService, DefinitionManager>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<IUserDal, EFUserDal>();
            services.AddScoped<IUserAddressDal, EFUserAddressDal>();
            services.AddScoped<IUserCreditDal, EFUserCreditDal>();

            services.AddScoped<ILexiconDal, EFLexiconDal>();
            services.AddScoped<IPageDal, EFPageDal>();
            services.AddScoped<ICultureDal, EFCultureDal>();
            services.AddScoped<ICityDal, EFCityDal>();
            services.AddScoped<ICountryDal, EFCountryDal>();

            services.AddControllers();

            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
