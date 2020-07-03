using Domain.Usuario.Paciente;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._2_RegistrarPaciente
{
    class Ctrl_RegistrarPaciente
    {
        public String verificarCedula(String idPaciente)
        {
            try
            {
                if (idPaciente is null)
                    return "{null}";

                IPaciente paciente = RepositorioPacientes.GetPaciente(int.Parse(idPaciente));
                return System.Text.Json.JsonSerializer.Serialize(paciente);

            }
            catch (CedulaYaExisteException ex)
            {
                throw ex;
            }

        }
    }
}
