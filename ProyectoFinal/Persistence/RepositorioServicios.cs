using Domain.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using com.sun.istack.@internal;

namespace Persistence
{
    public static class RepositorioServicios
    {
        public static IServicio verificarCodigo(int codigoServicio)
        {
            List<Servicio> servicios;

            String jsonString = FakeDB.TablaServicios.ToJSON();
            servicios = System.Text.Json.JsonSerializer.Deserialize<List<Servicio>>(jsonString);

            IServicio servicio = servicios.FirstOrDefault(p => p.codigoServicio == codigoServicio);
            
            return servicio;
        }

        public static IServicio verificarCodigo1(int? codigoServicio) 
        {
            List<Servicio> servicios;

            String jsonString = FakeDB.TablaServicios.ToJSON();
            servicios = System.Text.Json.JsonSerializer.Deserialize<List<Servicio>>(jsonString);

            IServicio servicio = servicios.FirstOrDefault(p => p.codigoServicio == codigoServicio);
            if (!(servicio is null))
            {
                throw new ServicioYaExisteException("El servicio : " + codigoServicio + ", ya está registrado");
            }
            return servicio;
        }

        public static List<Servicio> crearServicio(int codigoSer)
        {
            List<Servicio> servicios = new List<Servicio>();


            string nombreServicio = "NombreServicio" + codigoSer;
            string descripcion = "DescripcionServicio" + codigoSer;

            Servicio servicio1 = new Servicio(codigoSer, nombreServicio, descripcion);

            servicios.Add(servicio1);

            foreach (Servicio servicioD in servicios)
            {
                Console.WriteLine(servicioD);
            }

            return servicios;

           
        }

        
    }

    
}
