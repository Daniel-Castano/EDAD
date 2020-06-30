using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    public class TablaHistoriaClinica
    {
        private static readonly List<AtributosHistoria> pacientes = new List<AtributosHistoria>();

        class AtributosHistoria
        {

            public int Cedula { get; set; }
            public int NumeroFolio { get; set; }
            public string Descripcion { get; set; }

            public AtributosHistoria(int id)
            {
                Random random = new Random();

                Cedula = 1000 + id;

                NumeroFolio = 980 + id;

                Descripcion = "descripcion" + id;
            }

            public String ToJSON()
            {
                return System.Text.Json.JsonSerializer.Serialize(this);
            }
        }

        public static void InstanciarHistorias(int numeroPacientes)
        {
            for (int i = 0; i < numeroPacientes; i++)
            {
                pacientes.Add(new AtributosHistoria(i));

            }
        }

        public static String ToJSON()
        {
            if (pacientes.Count == 0)
            {
                InstanciarHistorias(10);
            }
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            return System.Text.Json.JsonSerializer.Serialize(pacientes, options);
        }
    }
}
