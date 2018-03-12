using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreIdentityMysql.API.Data;
using AspNetCoreIdentityMysql.API.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspNetCoreIdentityMysql.API
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
            var strConexao = Configuration.GetConnectionString("DefaultConnectionMysql");
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseMySql(strConexao));


            //CONFIGURAÇÕES DO IDENTITY            
            services.Configure<IdentityOptions>(options =>
            {
                //SENHA
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireLowercase = false;

                //LOCKOUT
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;

            });

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                // Signin settings
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                //CONFIG DO USUARIO
                options.User.RequireUniqueEmail = true;
            })
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {

            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
           {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //adicionados
            app.UseAuthentication();
        }
    }
}
