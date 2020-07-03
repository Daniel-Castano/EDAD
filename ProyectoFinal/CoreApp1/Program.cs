using Application._1_CrearServicio;
using Domain.Servicio;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CoreApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 0;
            string fecha = "23-09-1958";
            string telefono = "312215416j";

            string fechaF = fecha.Substring(6);

            int fechaCorrecta = int.Parse(fechaF);

            bool result = int.TryParse(telefono, out i);








            if (!(telefono.Length == 10 || result == true))
            {

                Console.WriteLine("telefono malo");

            }
            else
            {
                Console.WriteLine("telefono bueno");
            }
            if (fechaCorrecta > 1960)
            {
                Console.WriteLine("fecha mala");
            }

        }
    }
}