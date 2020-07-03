using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FakeDB;
using Microsoft.EntityFrameworkCore;
using Domain.Servicio;

namespace Services
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
            services.AddDbContext<ServiceDBContext>(options => options.UseInMemoryDatabase("ServiciosDB"));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ServiceDBContext context)
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

            if (!context.Servicios.Any())
            {
                context.Servicios.AddRange(new List<Servicio>()
                {
                    new Servicio()
                    {
                        codigoServicio= 20,
                        nombreServicio= "NombreServicio20",
                        descripcion= "DescripcionServicio20"
                    },
                    new Servicio()
                    {
                        codigoServicio= 21,
                        nombreServicio= "NombreServicio21",
                        descripcion= "DescripcionServicio21"
                    },
                    new Servicio()
                    {
                        codigoServicio= 22,
                        nombreServicio= "NombreServicio22",
                        descripcion= "DescripcionServicio22"
                    },
                    new Servicio()
                    {
                        codigoServicio= 23,
                        nombreServicio= "NombreServicio23",
                        descripcion= "DescripcionServicio23"
                    },
                    new Servicio()
                    {
                        codigoServicio= 24,
                        nombreServicio= "NombreServicio24",
                        descripcion= "DescripcionServicio24"
                    },
                    new Servicio()
                    {
                        codigoServicio= 25,
                        nombreServicio= "NombreServicio25",
                        descripcion= "DescripcionServicio25"
                    }
                });
                context.SaveChanges();
            }

           
        }
    }
}
