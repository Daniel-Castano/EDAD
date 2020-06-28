using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.HistoriaClinica
{
    public class HistoriaClinicaNoDisponibleException:Exception
    {
        public HistoriaClinicaNoDisponibleException()
        {

        }

        public HistoriaClinicaNoDisponibleException(string message) : base(message)
        {

        }

        public HistoriaClinicaNoDisponibleException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
