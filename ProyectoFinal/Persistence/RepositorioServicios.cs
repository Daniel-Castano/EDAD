using Domain.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Persistence
{
    public static class RepositorioServicios
    {
        public static IServicio verificarCodigo(int codigoServicio)
        {
            List<Servicio> servicios;
            

            String jsonString = FakeDB.Usuario.ToJSON();
            servicios = System.Text.Json.JsonSerializer.Deserialize<List<Servicio>>(jsonString);

            
            IServicio serviciosD = servicios.FirstOrDefault(p => p.codigoServicio == codigoServicio);
            if (serviciosD is null)
            {
                throw new ServicioYaExisteException("El Servicio que intenta crear -->" +codigoServicio + ", ya está disponible en el sistema");
            }
           

            return serviciosD;

        }
    }
}
