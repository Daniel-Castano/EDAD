using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Usuario.Paciente
{
    class DatosNoValidosException: Exception
    {
        public DatosNoValidosException()
        {

        }

        public DatosNoValidosException(string message) : base(message)
        {

        }

        public DatosNoValidosException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
