using Domain.Usuario.Paciente;
using Domain.Usuario.PacienteApp;
using System;
using System.Collections.Generic;
using System.Linq;
using FakeDB; 

namespace Persistence
{
    public static class RepositorioPacientes
    {
        public static IPaciente GetPaciente(int idPaciente)
        {
            List<PacienteAfiliado> pacientes;

            String jsonString = FakeDB.Usuario.ToJSON();
            pacientes = System.Text.Json.JsonSerializer.Deserialize<List<PacienteAfiliado>>(jsonString);

            IPaciente paciente = pacientes.FirstOrDefault(p => p.Cedula == idPaciente);
            if (paciente is null)
            {
                throw new CedulaYaExisteException("El Paciente con Cédula-->" + idPaciente + ", ya está registrado en el sistema");
            }

            return paciente; 

        }

        public static IPaciente ObtenerCedula(int? idPaciente)
        {
            List<PacienteAfiliado> pacientes;

            String jsonString = FakeDB.Usuario.ToJSON();
            pacientes = System.Text.Json.JsonSerializer.Deserialize<List<PacienteAfiliado>>(jsonString);

            IPaciente paciente = pacientes.FirstOrDefault(p => p.Cedula == idPaciente);
            if (!(paciente is null))
            {
                throw new CedulaYaExisteException("El Paciente con Cédula-->" + idPaciente + ", ya está registrado en el sistema");
            }

            return paciente;

        }

        
    }
}
