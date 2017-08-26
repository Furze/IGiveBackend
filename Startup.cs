using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace GiveAShitBackend
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
            
            var connection = "Server=" + Configuration["db:server"] + ";Database=" + Configuration["db:database"] + ";user id=" + Configuration["db:user"] + ";password=" + Configuration["db:password"] + ";";
            services.AddDbContext<GASDbContext>(options => options.UseSqlServer(connection));

            services.AddMvc();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IBarcodeService, BarcodeSevice>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());

            app.UseMvc();
        }
    }
}
