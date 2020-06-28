using System;
using System.Collections.Generic;
using System.Text;

namespace FakeDB
{
    class TablaServicios
    {
        private static List<AtributosServicio> servicio = new List<AtributosServicio>();

        class AtributosServicio
        {
            public int codigoServicio { get; set; }
            public string nombreServicio { get; set; }
            public string descripcion { get; set; }

            public AtributosServicio(int id)
            {
                Random random = new Random();

                codigoServicio = 20 + id;

                nombreServicio = "NombreServicio" + id;

                descripcion = "DescripcionServicio" + id;
            }

            public String ToJSON()
            {
                return System.Text.Json.JsonSerializer.Serialize(this);
            }
        }

        public static void InstanciarServiciosExistentes(int cantidadServicios)
        {
            for (int i = 0; i < cantidadServicios; i++)
            {
                servicio.Add(new AtributosServicio(i));

            }
        }

        public static String ToJSON()
        {
            if (servicio.Count == 0)
            {
                InstanciarServiciosExistentes(10);
            }
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            };

            return System.Text.Json.JsonSerializer.Serialize(servicio, options);
        }

    }
}
