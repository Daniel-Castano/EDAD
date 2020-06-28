using Domain.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence;

namespace Application._1_CrearServicio
{
    class Ctrl_CrearServicio
    {
        public String verificarCodigo(String codigoServicio)
        {
            try
            {
                if (codigoServicio is null)
                    return "{null}";

                IServicio servicio = RepositorioServicios.verificarCodigo(int.Parse(codigoServicio));
                return System.Text.Json.JsonSerializer.Serialize(servicio);

            }
            catch (ServicioYaExisteException ex)
            {
                throw ex;
            }

        }

        
    }

}
