using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    public class DatosMedico
    {
        private static readonly List<AtributosMedico> pacientes = new List<AtributosMedico>();
        class AtributosMedico
        {
            public string Especialidad { get; set; }
            public string TarjetaProfesional { get; set; }
         


            public AtributosMedico(int id)
            {
                Random random = new Random();

                Especialidad = "EspecialidadMedico" + id;

                TarjetaProfesional = "TarjetaProfesionalMedico" + id;

             

            }

            public String ToJSON()
            {
                return System.Text.Json.JsonSerializer.Serialize(this);
            }


        }


        public static void InstanciarPacientes(int numeroPacientes)
        {
            for (int i = 0; i < numeroPacientes; i++)
            {
                pacientes.Add(new AtributosMedico(i));

            }
        }

        public static String ToJSON()
        {
            if (pacientes.Count == 0)
            {
                InstanciarPacientes(10);
            }
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            return System.Text.Json.JsonSerializer.Serialize(pacientes, options);
        }
    }
}

