using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Valoracion
{
    public class Valoracion: IValoracion
    {

        public int cedula { get; set; }
        public string estadoValoracion { get; set; }
    }
}
