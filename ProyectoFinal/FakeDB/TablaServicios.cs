using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    class TablaServicios
    {
        private static readonly List<AtributosServicio> pacientes = new List<AtributosServicio>();

        class AtributosServicio
        {
            public string codigoServicio { get; set; }
            public string nombreServicio { get; set; }
            public string descripcion { get; set; }
        }
    }
}
