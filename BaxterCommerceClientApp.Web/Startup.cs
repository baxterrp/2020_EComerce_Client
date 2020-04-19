using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaxterCommerce.Client;
using BaxterCommerceClientApp.Web.Services;
using BaxterCommerceClientApp.Web.Services.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BaxterCommerceClientApp.Web
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
            services.AddSingleton<IUserService, UserService>();

            // wire up client from web app
            var eCommApiClientConfig = new ClientConfiguration
            {
                BaseAddress = "https://localhost:10001", 
                MediaType = "application/json"
            };

            services.AddSingleton<IAuthenticationClient, AuthenticationClient>(sp => new AuthenticationClient(eCommApiClientConfig));
            services.AddSingleton<IUserRegistrationClient, UserRegistrationClient>(sp => new UserRegistrationClient(eCommApiClientConfig));

            services.AddCors(sp => sp.AddPolicy("StandardPolicy", builder =>
            {
                builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader();
            }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("StandardPolicy");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
