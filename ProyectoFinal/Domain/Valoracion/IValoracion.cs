using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Valoracion
{
    interface IValoracion
    {

        public int cedula { get; set; }
        public string estadoValoracion { get; set; }
    }
}
