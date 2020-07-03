using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Usuario.Paciente
{
    public class CedulaYaExisteException: Exception
    {
        public CedulaYaExisteException()
        {

        }

        public CedulaYaExisteException (string message): base(message)
        {

        }

        public CedulaYaExisteException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
