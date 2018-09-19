using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using MiniWeb.Persistence;
using MiniWeb.Persistence.Abstractions;
using Newtonsoft.Json;

namespace MiniWeb
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICountryRepository>(new CountryRepository());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment env,
            ICountryRepository country)
        {
            app.Map("/country", countryApp =>
            {
                countryApp.Run(async (context) =>
                {
                    //var country = provider.GetService<ICountryRepository>();
                    var query = context.Request.Query["q"];
                    var list = country.AllBy(query).ToList();
                    var json = JsonConvert.SerializeObject(list);

                    await context.Response.WriteAsync(json);
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Invalid call");
            });
        }
    }
}
