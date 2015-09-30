﻿using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Cors.Core;
using Microsoft.Framework.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace Lisa.Mugshot.WebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            var policy = new CorsPolicy();
            policy.Headers.Add("*");
            policy.Methods.Add("*");
            policy.Origins.Add("*");
            services.ConfigureCors(config => config.AddPolicy("allowAll", policy));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCors("allowAll");
            app.UseMvc();
        }
    }
}