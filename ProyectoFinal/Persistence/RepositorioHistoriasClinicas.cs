using Domain.HistoriaClinica;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Persistence
{
    public class RepositorioHistoriasClinicas
    {
        public static IHistoriaClinica GetPaciente(int idPaciente) 
        {
            List<HistoriaClinica> historias;

            String jsonString = FakeDB.TablaHistoriaClinica.ToJSON();
            historias = System.Text.Json.JsonSerializer.Deserialize<List<HistoriaClinica>>(jsonString);

            IHistoriaClinica historia = historias.FirstOrDefault(p => p.Cedula == idPaciente);
            if (historia is null)
            {
                throw new HistoriaClinicaNoDisponibleException("El Paciente con Cédula: " + idPaciente + ", no tiene historia clinica registrada");
            }

            return historia; 

        }

    }
}
