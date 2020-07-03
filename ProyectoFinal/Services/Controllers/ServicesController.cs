using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Servicio;
using Application._1_CrearServicio;
using javax.smartcardio;
using static FakeDB.TablaServicios;

namespace Services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        
        [HttpGet]

          public IEnumerable<Servicio> Get()
          {
              List<Servicio> servicios;

              String jsonString = FakeDB.TablaServicios.ToJSON();
              servicios = System.Text.Json.JsonSerializer.Deserialize<List<Servicio>>(jsonString);

              return servicios.ToList();
          }


          [HttpGet("{id}")]

          public String Get(string id)
          {
              Ctrl_CrearServicio ctrlC = new Ctrl_CrearServicio();

             
                  return ctrlC.informacionServicio(id);

          }

          [HttpPost]

          public IActionResult Post([FromBody] Servicio servicio)
          {

           Ctrl_CrearServicio ctrlC = new Ctrl_CrearServicio();

           List<Servicio> servicios = new List<Servicio>();

            List<TablaServicios> servicios1 = new List<TablaServicios>();

           List<AtributosServicio> serv = new List<AtributosServicio>();

           try
           {
               if (ModelState.IsValid)
               {
                    

                    if (ctrlC.verificarCodigo(servicio.codigoServicio) == false)
                    {

                        servicios.Add(servicio);
                        serv.Add(new AtributosServicio(servicio.codigoServicio) { codigoServicio=servicio.codigoServicio, nombreServicio=servicio.nombreServicio, descripcion=servicio.descripcion});
                        
                    }
                   

                   return new CreatedAtRouteResult("servicio creado", new { servicio });
               }
           }
           catch(ServicioYaExisteException ex)
           {
               return BadRequest(ex.Message);
           }

           return BadRequest(ModelState);

       }



    }
}