using Domain.Usuario.Paciente;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._2_RegistrarPaciente
{
    public class Ctrl_RegistrarPaciente
    {
        
        public bool verificarCedula(int? cedulaPaciente)
        {
            try
            {
                if (cedulaPaciente == null)
                {
                    return false;
                }
                else
                {
                    IPaciente paciente = RepositorioPacientes.ObtenerCedula((cedulaPaciente.GetValueOrDefault()));
                    return true;
                }
            }
            catch (CedulaYaExisteException ex)
            {
                throw ex;
            }

        }

        public bool verificarDatos(string telefono, string fecha)
        {

            
            string fechaF = fecha.Substring(6);

            int fechaCorrecta = int.Parse(fechaF);

          

            if (telefono.Length != 10)
            {
                return false;
                throw new DatosNoValidosException("El teléfono ingresado no es válido");
                
            }
            if (fechaCorrecta > 1960)
            {
                return false;
                throw new DatosNoValidosException("El paciente no puede acceder a los servicios, debe ser mayor a 59 años");
            }
            return true;
        }


    }
}
