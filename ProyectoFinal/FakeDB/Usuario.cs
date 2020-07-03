using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    public class Usuario
    {
        private static readonly List<AtributosUsuario> pacientes = new List<AtributosUsuario>();
        class AtributosUsuario
        {
            public int Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string FechaNacimiento { get; set; }
            public string Direccion { get; set; }
           


            public AtributosUsuario(int id)
            {
                Random random = new Random();

                Cedula = 1000 +id; 
             
                Nombre = "NombreUsurio" + id;

                Apellido = "ApellidoUsuario" + id;
               
                Telefono = "Telefono" + id;

                FechaNacimiento = "30-12-2011";

                Direccion = "direccion" + id;

               
             
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
                pacientes.Add(new AtributosUsuario(i));

            }
        }

        public static String ToJSON()
        {
            if (pacientes.Count == 0)
            {
                InstanciarPacientes(12);
            }
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            return System.Text.Json.JsonSerializer.Serialize(pacientes, options);
        }
    }
}
