using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Servicio
{
    public class InformacionNoValidaException: Exception
    {
        public InformacionNoValidaException()
        {

        }

        public InformacionNoValidaException(string message) : base(message)
        {

        }

        public InformacionNoValidaException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
