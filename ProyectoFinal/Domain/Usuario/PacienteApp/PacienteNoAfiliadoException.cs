using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Usuario.Paciente
{
    public class PacienteNoAfiliadoException: Exception
    {
        public PacienteNoAfiliadoException(string message) : base(message)
        {

        }

        public PacienteNoAfiliadoException (string message, Exception inner): base(message, inner)
        {

        }
    }
}
