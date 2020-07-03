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
            fecha = fecha.Substring(6);
            int fechaComprobar = int.Parse(fecha);  

            if (telefono.Length != 10 || !(double.TryParse(telefono, out double i)))
            {
                throw new DatosNoValidosException("El teléfono ingresado no es válido");
            }

            if (fechaComprobar > 1960)
            {
                throw new DatosNoValidosException("El paciente no puede acceder a los servicios, debe tener más de 59 años");
            }
            return true;
        }


    }
}
