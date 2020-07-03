using Application._5_ConsultarHistoriaClinica;
using Domain.HistoriaClinica;
using Domain.Usuario.Paciente;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application._4_ValorarPaciente
{
    public class Ctrl_ValorarPaciente
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
                    IPaciente paciente = RepositorioPacientes.ObtenerCedula(cedulaPaciente);
                    return true;
                }
            }
            catch (CedulaYaExisteException ex)
            {
                throw ex;
            }

        }

        public bool solicitarHistoriaClinica(int? cedula) 
        {
            try
            {
                if (cedula == null)
                {
                    return false;
                }
                else
                {
                    IHistoriaClinica historia = RepositorioHistoriasClinicas.GetPaciente(cedula.GetValueOrDefault());
                    return true;
                }
            }
            catch (HistoriaClinicaNoDisponibleException ex)
            {
                throw ex;
            }
        }

      
    }
}
