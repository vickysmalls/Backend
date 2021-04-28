using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using oslometAPI.Data;

namespace oslometAPI
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<oslometContext>(options => options.UseSqlite("Data Source=OsloMet.db"));

            services.AddCors();
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddScoped<IKlasserRepository, KlasserRepository>();
            services.AddScoped<IMasterFagRepository, MasterFagRepository>();
            services.AddScoped<IObligFagsRepository, ObligFagsRepository>();
            services.AddScoped<IMuligheterRepository, MuligheterRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                loggerFactory.AddFile("Logs/OsloMetLogs");
                app.UseDeveloperExceptionPage();

            }

            DBInit.Seed(app);

            app.UseRouting();



            app.UseStaticFiles(); //merk denne!

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
