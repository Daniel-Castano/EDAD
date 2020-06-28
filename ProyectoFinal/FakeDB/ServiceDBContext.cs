using Domain.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    public class ServiceDBContext: DbContext 
    {

        public ServiceDBContext(DbContextOptions<ServiceDBContext> options): base(options)
        {

        }
        public DbSet<Servicio> Servicios { get; set; }
    }
}
