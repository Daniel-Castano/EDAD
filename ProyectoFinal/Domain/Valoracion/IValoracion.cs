using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Valoracion
{
    interface IValoracion
    {

        public string estadoValoracion { get; set; }
        public int cedula { get; set; }
    }
}
