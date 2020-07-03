using Domain.Usuario.Paciente;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Usuario.PacienteApp
{
    public class PacienteAfiliado: IPaciente
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string actividadesRegulares { get; set; }
        
    }
}
