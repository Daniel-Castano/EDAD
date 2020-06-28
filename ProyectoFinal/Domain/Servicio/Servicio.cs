using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Servicio
{
    public class Servicio: IServicio
    {
        public int codigoServicio { get; set; }
        public string nombreServicio { get; set; }
        public string descripcion { get; set; }
    }
}
