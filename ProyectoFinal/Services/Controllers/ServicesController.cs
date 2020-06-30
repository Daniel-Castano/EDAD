using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Servicio;
using Application._1_CrearServicio;

namespace Services.Controllers
{

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

            try
            {
                return ctrlC.verificarCodigo(id);
            }
            catch (ServicioYaExisteException ex)
            {
                return "{" + ex.Message + "}";
            }
        }


    }
}