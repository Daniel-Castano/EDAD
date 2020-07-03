using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Usuario.Paciente
{
    public interface IPaciente
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
