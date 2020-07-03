using Domain.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence;

namespace Application._1_CrearServicio
{
    public class Ctrl_CrearServicio
    {
        public String informacionServicio(String codigoServicio) 
        {
            
                if (codigoServicio is null)
                    return "{null}";

                IServicio servicio = RepositorioServicios.verificarCodigo(int.Parse(codigoServicio));
                return System.Text.Json.JsonSerializer.Serialize(servicio);   

        }
        
        public bool verificarCodigo(int? codigoServicio)
        {
            try
            {
                if (codigoServicio == null)
                {
                    return false;
                }
                else
                {
                    IServicio servicio = RepositorioServicios.verificarCodigo1((codigoServicio));
                    return true;
                }
            }
            catch (ServicioYaExisteException ex)
            {
                throw ex;
            }

        }
    }
}
