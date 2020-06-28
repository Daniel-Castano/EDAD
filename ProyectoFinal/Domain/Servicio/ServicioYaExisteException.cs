using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Servicio
{
    public class ServicioYaExisteException:Exception
    {
        public ServicioYaExisteException()
        {

        }

        public ServicioYaExisteException(string message) : base(message)
        {

        }

        public ServicioYaExisteException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
