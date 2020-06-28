using Domain.Usuario.Paciente;
using Persistence;
using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPaciente p = RepositorioPacientes.GetPaciente(10001);

            }
            catch (PacienteNoAfiliadoException ex)
            {
                Console.WriteLine("ERROR-->" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
