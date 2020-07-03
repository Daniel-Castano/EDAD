using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    public class TablaValoracionesPaciente
    {
        private static readonly List<AtributosValoracion> pacientes = new List<AtributosValoracion>();

        class AtributosValoracion
        {
            public int cedula { get; set; }
            public string estadoValoracion { get; set; }
        } 
    }
}
