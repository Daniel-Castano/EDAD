using Application._1_CrearServicio;
using Application._2_RegistrarPaciente;
using Domain.Servicio;
using Domain.Usuario.Paciente;
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

            string telefono = "32257";
            string fecha = "01-01-1960";


            Ctrl_RegistrarPaciente ctrlC = new Ctrl_RegistrarPaciente();

            try
            {
                ctrlC.verificarDatos(telefono, fecha);
            }

            catch (DatosNoValidosException ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}