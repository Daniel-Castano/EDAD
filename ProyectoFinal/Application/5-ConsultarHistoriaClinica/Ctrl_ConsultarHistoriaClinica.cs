using Domain.HistoriaClinica;
using Domain.Usuario.Paciente;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;


namespace Application._5_ConsultarHistoriaClinica
{
    public class Ctrl_ConsultarHistoriaClinica
    {
        public String solicitarHistoriaClinica(String idPaciente)
        {
            try
            {
                if (idPaciente is null)
                    return "{null}"; 
                
                IHistoriaClinica paciente = RepositorioHistoriasClinicas.GetPaciente(int.Parse(idPaciente));
                return System.Text.Json.JsonSerializer.Serialize(paciente);

            }
            catch (HistoriaClinicaNoDisponibleException ex) 
            {
                throw ex;
            }
            
        }

    }
}
