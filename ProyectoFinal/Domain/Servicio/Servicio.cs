using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Servicio
{
    public class Servicio : IServicio
    {

        public Servicio()
        {

        }
        public Servicio(int codigoServicio, string nombreServicio, string descripcion)
        {
            this.codigoServicio = codigoServicio;
            this.nombreServicio = nombreServicio;
            this.descripcion = descripcion;
        }


        [Key]
        public int codigoServicio { get; set; }
        public string nombreServicio { get; set; }
        public string descripcion { get; set; }

    }

   
}
