using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using FileServer.Common;
using Microsoft.Extensions.FileProviders;

namespace FileServer
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use(async (context, nextMiddleware) =>
            {
                // first pass here
                var isMobile = context.IsMobileDevice();
                context.Items["Mobile"] = isMobile;

                if (isMobile)
                {
                    await context.Response.WriteAsync("MOBILE DEVICE DETECTED");
                    return;
                }

                await nextMiddleware();   // optional, but ...

                // second pass here
            });

            // Enable serving files from the configured web root folder (i.e., WWWROOT)
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Enable serving files from \Assets located under the root folder of the site
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), @"Assets")),
                RequestPath = new PathString("/Public/MyAssets")
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(context.Items["Mobile"].ToString());
            });
        }
    }
}
