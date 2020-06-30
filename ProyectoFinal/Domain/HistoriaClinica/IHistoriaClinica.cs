using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.HistoriaClinica
{
    public interface IHistoriaClinica
    {
        public int Cedula { get; set; }
        public int NumeroFolio { get; set; }
        public string Descripcion { get; set; }
    }
}
