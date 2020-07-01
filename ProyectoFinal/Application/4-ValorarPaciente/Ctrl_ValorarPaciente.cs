using Application._5_ConsultarHistoriaClinica;
using Domain.Usuario.Paciente;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._4_ValorarPaciente
{
    public class Ctrl_ValorarPaciente
    {
        public String verificarCedula(String cedulaPaciente)
        {
            try
            {
                if (cedulaPaciente is null)

                    return "{null}";

                IPaciente paciente = RepositorioPacientes.GetPaciente(int.Parse(cedulaPaciente));
                //solicitarHistoriaClinica(cedulaPaciente);
                return System.Text.Json.JsonSerializer.Serialize(paciente);

               
            }
            catch (PacienteNoAfiliadoException ex)
            {
                throw ex;
            }

        }

        public String solicitarHistoriaClinica(string cedula)
        {
            Ctrl_ConsultarHistoriaClinica ctr1 = new Ctrl_ConsultarHistoriaClinica();

            return ctr1.solicitarHistoriaClinica(cedula);
        }
    }
}
